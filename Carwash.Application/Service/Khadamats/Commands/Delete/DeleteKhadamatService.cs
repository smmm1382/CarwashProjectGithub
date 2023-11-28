using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Khadamats.Commands.Delete;

public class DeleteKhadamatService : IDeleteKhadamatService
{
    private readonly IAppDbContext _context;

    public DeleteKhadamatService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto> Execute(int id)
    {
        var khadamat = await _context.Khadamats.FindAsync(id);

        if (khadamat == null)
        {
            return new ResultDto
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404
            };
        }
        else
        {
            _context.Khadamats.Remove(khadamat);
            await _context.SaveChangesAsync();
        }
        return new ResultDto
        {
            IsSuccess = true,
            Message = "با موفقیت حذف شد",
            StatusCode = 200
        };
    }
}
