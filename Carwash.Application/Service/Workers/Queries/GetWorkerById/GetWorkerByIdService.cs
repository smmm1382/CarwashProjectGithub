using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Workers.Queries.GetWorkerById;

public class GetWorkerByIdService : IGetWorkerByIdService
{
    private readonly IAppDbContext _context;
    public GetWorkerByIdService(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<ResultDto<Worker>> Execute(int id)
    {
        var worker = await _context.Workers.FindAsync(id);

        if (worker == null)
        {
            return new ResultDto<Worker>
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404
            };
        }
        else
        {
            return new ResultDto<Worker>
            {
                IsSuccess = true,
                Message = "با موفقیت انجام شد",
                StatusCode = 200,
                Data = worker
            };
        }
    }
}
