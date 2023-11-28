using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using CryptoHelper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Managers.Commands.Create;

public class CreateManagerService : ICreateManagerService
{
    private readonly IAppDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public CreateManagerService(IAppDbContext context, IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public ResultDto<CreateManagerDto> Execute(CreateManagerDto createManagerDto)
    {
        var flag = _context.Managers.Any(d => d.Email == createManagerDto.Email);

        if (flag == true)
        {
            return new ResultDto<CreateManagerDto>
            {
                IsSuccess = false,
                Message = "ایمیل شما تکراری است",
                StatusCode = 404
            };
        }
        else
        {
            var PasswordHashed = Crypto.HashPassword(createManagerDto.Password);

            //پرسیده شود
            string? filePath = null;

            if (createManagerDto.ImageFile != null)
            {
                filePath = Path.Combine(@"D:\DriveD\MyProject\Carwash\EndPoints.Api\pic", createManagerDto.ImageFile.FileName);
                var stream = new FileStream(filePath, FileMode.Create);
                createManagerDto.ImageFile.CopyTo(stream);
            }



            Manager manager = new Manager
            {
                FirstName = createManagerDto.FirstName,
                LastName = createManagerDto.LastName,
                Email = createManagerDto.Email,
                Password = PasswordHashed,
                ImageFile = filePath
            };



            var fullName = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(d => d.Type == "FullName").Value;

            History history = new History
            {
                CrationDate = DateTime.Now,
                ActionTitle = "درج ادمین",
                FullName = fullName,
            };


            //پرسیده شود
            ManagerInHistory managerInHistory = new ManagerInHistory
            {
                Manager = manager,
                History = history
            };

            _context.ManagerInHistories.Add(managerInHistory);
            _context.SaveChanges();


            return new ResultDto<CreateManagerDto>
            {
                IsSuccess = true,
                Message = "ادمین با موفقیت اضافه شد",
                StatusCode = 200,
                Data = createManagerDto
            };

        }
    }
}
