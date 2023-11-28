using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Khadamats.Queries.GetKhadamat;

public class GetKhadamatService : IGetKhadamatService
{
    private readonly IAppDbContext _context;
    public GetKhadamatService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto<List<Khadamat>>> Execute()
    {
        var khadamat = await _context.Khadamats.ToListAsync();

        return new ResultDto<List<Khadamat>>
        {
            IsSuccess = true,
            Message = "با موفقیت انجام شد",
            StatusCode = 200,
            Data = khadamat
        };
    }
}
