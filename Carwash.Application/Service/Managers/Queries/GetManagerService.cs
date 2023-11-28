using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Managers.Queries;

public class GetManagerService : IGetManagerService
{
    private readonly IAppDbContext _context;
    public GetManagerService(IAppDbContext context)
    {
        _context = context;
    }

    public ResultDto<List<Manager>> Execute()
    {
        var manager = _context.Managers.ToList();

        return new ResultDto<List<Manager>>
        {
            IsSuccess = true,
            Message = "با موفقیت انجام شد",
            StatusCode = 200,
            Data = manager
        };
    }
}
