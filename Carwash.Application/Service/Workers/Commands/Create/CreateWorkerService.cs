using Carwash.Application.Interface;
using Carwash.Application.Service.Workers.Commands.Create;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Workers.Command.Create;

public class CreateWorkerService : ICreateWorkerService
{
    private readonly IAppDbContext _context;
    public CreateWorkerService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto<CreateWorkerDto>> Execute(CreateWorkerDto createWorkerDto)
    {
        Worker worker1 = new Worker()
        {
            FirstName = createWorkerDto.FirstName,
            LastName = createWorkerDto.LastName,
            Age = createWorkerDto.Age,
            PhoneNumber = createWorkerDto.PhoneNumber
        };
        //ورودی ها از هم جدا شود
        if (createWorkerDto.FirstName == null || createWorkerDto.LastName == null || createWorkerDto.Age == null)
        {
            return new ResultDto<CreateWorkerDto>
            {
                IsSuccess = false,
                Message = "این فیلد نمیتواند خالی باشد",
                StatusCode = 404
            };
        }
        else if(createWorkerDto.PhoneNumber.Length >= 12)
        {
            return new ResultDto<CreateWorkerDto>
            {
                IsSuccess = false,
                Message = "شماره موبایل باید یازده رقم باشد",
                StatusCode = 404
            };
        }
        else if (createWorkerDto.Age < 10 || createWorkerDto.Age > 50)
        {
            return new ResultDto<CreateWorkerDto>
            {
                IsSuccess = false,
                Message = "سن کارگر باید بین 10 تا 50 سال باشد",
                StatusCode = 404
            };
        }
        else
        {
            await _context.Workers.AddAsync(worker1);
            await _context.SaveChangesAsync();
        }

        return new ResultDto<CreateWorkerDto>
        {
            IsSuccess = true,
            Message = "کارگر با موفقیت اضافه شد",
            StatusCode = 200,
            Data = createWorkerDto
        };
    }
}
