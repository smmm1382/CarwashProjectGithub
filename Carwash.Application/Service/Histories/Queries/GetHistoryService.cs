using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Histories.Queries;

public class GetHistoryService : IGetHistoryService
{
    private readonly IAppDbContext _context;
    public GetHistoryService(IAppDbContext context)
    {
        _context = context;
    }
    public ResultDto<List<History>> Execute()
    {
        var history = _context.Histories.ToList();
        {
            return new ResultDto<List<History>>
            {
                IsSuccess = true,
                Message = "با موفقیت انجام شد",
                StatusCode = 200,
                Data = history
            };
        }
    }
}






