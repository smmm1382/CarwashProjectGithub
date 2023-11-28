using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Khadamats.Commands.Create;

public class CreateKhadamatService : ICreateKhadamatService
{
    private readonly IAppDbContext _context;
    public CreateKhadamatService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto<CreateKhadamatDto>> Execute(CreateKhadamatDto createKhadamatDto)
    {
        Khadamat khadamat = new Khadamat
        {
            Name = createKhadamatDto.Name,
            Price = createKhadamatDto.Price,
        };

       await _context.Khadamats.AddAsync(khadamat);
       await _context.SaveChangesAsync();

        return new ResultDto<CreateKhadamatDto>
        {
            IsSuccess = true,
            Message = "خدمات با موفقیت اضافه شد",
            StatusCode = 200,
            Data = createKhadamatDto
        };
    }
}
