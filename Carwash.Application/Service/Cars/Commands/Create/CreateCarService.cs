using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Cars.Commands.Create;

public class CreateCarService : ICreateCarService
{
    private readonly IAppDbContext _context;
    public CreateCarService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto<CreateCarDto>> Execute(CreateCarDto createCarDto)
    {
        Car car = new Car
        {
            Name = createCarDto.Name
        };

        await _context.Cars.AddAsync(car);
        await _context.SaveChangesAsync();

        return new ResultDto<CreateCarDto>
        {
            IsSuccess = true,
            Message = "ماشین با موفقیت اضافه شد",
            StatusCode = 200,
            Data = createCarDto
        };
    }
}
