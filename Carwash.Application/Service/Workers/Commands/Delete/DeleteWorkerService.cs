using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Workers.Command.Delete;

public class DeleteWorkerService : IDeleteWorkerService
{
    private readonly IAppDbContext _context;

    public DeleteWorkerService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto> Execute(int id)
    {
        var worker = await _context.Workers.FindAsync(id);

        if (worker == null)
        {
            return new ResultDto
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404,
            };
        }
        else
        {
            _context.Workers.Remove(worker);
            await _context.SaveChangesAsync();
        }
        return new ResultDto
        {
            IsSuccess = true,
            Message = "کارگر با موفقیت حذف شد",
            StatusCode = 200
        };
    }
}
