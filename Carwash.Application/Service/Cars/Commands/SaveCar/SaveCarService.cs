using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Cars.Commands.SaveCar;

public class SaveCarService : ISaveCarService
{
    private readonly IAppDbContext _context;
    public SaveCarService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto<SaveCarDto>> Execute(SaveCarDto saveCarDto)
    {
        var flag = await _context.Cars.AnyAsync(d => d.Name == saveCarDto.Name);

        if (saveCarDto.Id == null && flag == true)
        {
            return new ResultDto<SaveCarDto>
            {
                IsSuccess = false,
                Message = "شما نمیتوانید ماشین تکراری اضافه کنید",
                StatusCode = 404
            };
        }
        else if (saveCarDto.Id == null)
        {
            Car car1 = new Car
            {
                Name = saveCarDto.Name
            };
            await _context.Cars.AddAsync(car1);
            await _context.SaveChangesAsync();
            return new ResultDto<SaveCarDto>
            {
                IsSuccess = true,
                Message = "ماشین با موفقیت اضافه شد",
                StatusCode = 200,
                Data = saveCarDto
            };
        }
        else
        {
            var car = await _context.Cars.FindAsync(saveCarDto.Id);

            if (car == null)
            {
                return new ResultDto<SaveCarDto>
                {
                    IsSuccess = false,
                    Message = "شناسه ی وارد شده یافت نشد",
                    StatusCode = 404
                };
            }
            else
            {
                car.Name = saveCarDto.Name;
            }
            await _context.SaveChangesAsync();

            return new ResultDto<SaveCarDto>
            {
                IsSuccess = true,
                Message = "ویرایش با موفقیت انجام شد",
                StatusCode = 200,
                Data = saveCarDto
            };
        }



    }
}
