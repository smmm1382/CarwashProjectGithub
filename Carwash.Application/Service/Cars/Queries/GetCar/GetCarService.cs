using Carwash.Application.Interface;
using Carwash.Common;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Cars.Queries.GetCar;

public class GetCarService : IGetCarService
{
    private readonly IAppDbContext _context;

    public GetCarService(IAppDbContext context)
    {
        _context = context;
    }


    public ResultDto<ArrayList> Execute(CarListDto carListDto)
    {
        var carlist = _context.Cars.ToList().ToPaged(carListDto.Page, carListDto.PageSize, out int rowscount).ToList();

        ArrayList data = new ArrayList()
        {
            carlist,
            new
            {
                RowNumber = rowscount
            }
        };

        return new ResultDto<ArrayList>()
        {
            IsSuccess = true,
            Message = "با موفقیت انجام شد",
            StatusCode = 200,
            Data = data
        };
    }
}
