using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Cars.Commands.Update;

public class UpdateCarService : IUpdateCarService
{
    private readonly IAppDbContext _context;

    public UpdateCarService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto<UpdateCarDto>> Execute(UpdateCarDto updateCarDto)
    {
        var car = await _context.Cars.FindAsync(updateCarDto.Id);

        if (car == null)
        {
            return new ResultDto<UpdateCarDto>
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404,
            };
        }
        else
        {
            car.Name = updateCarDto.Name;
            await _context.SaveChangesAsync();
        }
        

        return new ResultDto<UpdateCarDto>
        {
            IsSuccess = true,
            Message = "ویرایش با موفقیت انجام شد",
            StatusCode = 200,
            Data = updateCarDto
        };
    }
}
