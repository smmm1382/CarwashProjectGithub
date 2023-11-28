using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Cars.Queries.GetCarById;

public class GetCarByIdService : IGetCarByIdService
{
    private readonly IAppDbContext _context;

    public GetCarByIdService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto<Car>> Execute(int id)
    {
        var car = await _context.Cars.FindAsync(id);

        if (car == null)
        {
            return new ResultDto<Car>
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404,
            };
        }
        else
        {
            return new ResultDto<Car>
            {
                IsSuccess = true,
                Message = "با موفقیت انجام شد",
                StatusCode = 200,
                Data = car
            };
        }
    }
}
