using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Khadamats.Queries.SearchKhadamat;

public class SearchKhadamatService : ISearchKhadamatService
{
    private readonly IAppDbContext _context;

    public SearchKhadamatService(IAppDbContext context)
    {
        _context = context;
    }

    public ResultDto<List<Khadamat>> Execute(SearchKhadamatDto searchKhadamatDto)
    {
        var khadamat = _context.Khadamats.Where(d => d.Name.Contains(searchKhadamatDto.Name)).ToList();

        return new ResultDto<List<Khadamat>>
        {
            IsSuccess = true,
            Message = "با موفقیت انجام شد",
            StatusCode = 200,
            Data = khadamat
        };
    }
}
