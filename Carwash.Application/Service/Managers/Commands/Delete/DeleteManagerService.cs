using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Managers.Commands.Delete;

public class DeleteManagerService : IDeleteManagerService
{
    private readonly IAppDbContext _context;

    public DeleteManagerService(IAppDbContext context)
    {
        _context = context;
    }

    public ResultDto Execute(int id)
    {
        var manager = _context.Managers.Find(id);

        if (manager == null)
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
            _context.Managers.Remove(manager);
            _context.SaveChanges();
        }
        return new ResultDto
        {
            IsSuccess = true,
            Message = "ادمین با موفقیت حذف شد",
            StatusCode = 200
        };
    }
}
