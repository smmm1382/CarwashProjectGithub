using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Workers.Command.SaveWorker;

public class SaveWorkerService : ISaveWorkerService
{
    private readonly IAppDbContext _context;
    public SaveWorkerService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto<SaveWorkerDto>> Execute(SaveWorkerDto saveWorkerDto)
    {
        var flag = await _context.Workers.AnyAsync(d => d.Age > 30);

        if (saveWorkerDto.Id == null && flag == true && saveWorkerDto.Age > 30)
        {
            return new ResultDto<SaveWorkerDto>
            {
                IsSuccess = false,
                Message = "سن کارگر شما نمیتواند بیشتر از 30 سال باشد",
                StatusCode = 404
            };
        }
        else if (saveWorkerDto.Id == null)
        {
            Worker worker = new Worker
            {
                FirstName = saveWorkerDto.FirstName,
                LastName = saveWorkerDto.LastName,
                Age = saveWorkerDto.Age
            };
            await _context.Workers.AddAsync(worker);
            await _context.SaveChangesAsync();

            return new ResultDto<SaveWorkerDto>
            {
                IsSuccess = true,
                Message = "کارگر شما با موفقیت اضافه شد",
                StatusCode = 200,
                Data = saveWorkerDto
            };
        }
        else
        {
            var worker = await _context.Workers.FindAsync(saveWorkerDto.Id);

            if (worker == null)
            {
                return new ResultDto<SaveWorkerDto>
                {
                    IsSuccess = false,
                    Message = "شناسه ی وارد شده یافت نشد",
                    StatusCode = 404
                };
            }
            else
            {
                worker.FirstName = saveWorkerDto.FirstName;
                worker.LastName = saveWorkerDto.LastName;
                worker.Age = saveWorkerDto.Age;
                worker.Salary = saveWorkerDto.Salary;
                worker.Bonus = saveWorkerDto.Bonus;
            }
            await _context.SaveChangesAsync();
        }
        return new ResultDto<SaveWorkerDto>
        {
            IsSuccess = true,
            Message = "ویرایش با موفقیت انجام شد",
            StatusCode = 200,
            Data = saveWorkerDto
        };
    }
}
