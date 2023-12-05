using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Workers.Command.Update;

public class UpdateWorkerService : IUpdateWorkerService
{
    private readonly IAppDbContext _context;

    public UpdateWorkerService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto<UpdateWorkerDto>> Execute(UpdateWorkerDto updateWorkerDto)
    {
        var worker1 = await _context.Workers.FindAsync(updateWorkerDto.Id);
        if (worker1 == null)
        {
            return new ResultDto<UpdateWorkerDto>
            {
                IsSuccess = false,
                Message = "شناسه وارد شده یافت نشد",
                StatusCode = 404,
            };
        }
        else
        {
            worker1.FirstName = updateWorkerDto.FirstName;
            worker1.LastName = updateWorkerDto.LastName;
            worker1.Age = updateWorkerDto.Age;
            worker1.Salary = updateWorkerDto.Salary;
        }

        await _context.SaveChangesAsync();

        return new ResultDto<UpdateWorkerDto>
        {
            IsSuccess = true,
            Message = "ویرایش با موفقیت انجام شد",
            StatusCode = 200,
            Data = updateWorkerDto
        };
    }
}
//  worker1.FirstName = updateWorkerDto.FirstName;
//worker1.LastName = updateWorkerDto.LastName;
//  worker1.Age = updateWorkerDto.Age;
// worker1.Salary = updateWorkerDto.Salary;
