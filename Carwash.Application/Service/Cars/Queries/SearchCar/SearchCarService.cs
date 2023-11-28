using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Cars.Queries.SearchCar;

public class SearchCarService : ISearchCarService
{
    private readonly IAppDbContext _context;
    public SearchCarService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto<List<Car>>> Execute(SearchCarDto searchCarDto)
    {
        var car = await _context.Cars.Where(d => d.Name.Contains(searchCarDto.Name)).ToListAsync();

        if (car == null)
        {
            return new ResultDto<List<Car>>
            {
                IsSuccess = false,
                Message = "نتیجه ای یافت نشد",
                StatusCode = 404
            };
        }
        else
        {
            return new ResultDto<List<Car>>
            {
                IsSuccess = true,
                Message = "با موفقیت انجام شد",
                StatusCode = 200,
                Data = car
            };
        }

    }
}
