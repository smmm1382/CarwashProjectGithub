using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Khadamats.Queries.GetKhadamatById;

public class GetKhadamatByIdService : IGetKhadamatByIdService
{
    private readonly IAppDbContext _context;
    public GetKhadamatByIdService(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<ResultDto<Khadamat>> Execute(int id)
    {
        var khadamat = await _context.Khadamats.FindAsync(id);

        if (khadamat == null)
        {
            return new ResultDto<Khadamat>
            {
                IsSuccess = false,
                Message = "شناسه ی وارد شده یافت نشد",
                StatusCode = 404,
            };
        }
        else
        {
            return new ResultDto<Khadamat>
            {
                IsSuccess = true,
                Message = "با موفقیت انجام شد",
                StatusCode = 200,
                Data = khadamat
            };
        }
    }
}
