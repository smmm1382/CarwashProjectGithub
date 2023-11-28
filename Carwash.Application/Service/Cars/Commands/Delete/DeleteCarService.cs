using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Cars.Commands.Delete;

public class DeleteCarService : IDeleteCarService
{
    private readonly IAppDbContext _context;

    public DeleteCarService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto> Execute(int id)
    {
        var car = await _context.Cars.FindAsync(id);
        if(car == null)
        {
            return new ResultDto
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404
            };
        }
        else
        {
            _context.Cars.Remove(car);
           await _context.SaveChangesAsync();
        }

        return new ResultDto
        {
            IsSuccess = true,
            Message = "ماشین با موفقیت حذف شد",
            StatusCode = 200
        };
    }
    
}
