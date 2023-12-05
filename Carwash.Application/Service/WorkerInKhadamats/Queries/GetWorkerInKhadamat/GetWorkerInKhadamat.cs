using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.WorkerInKhadamats.Queries.GetWorkerInKhadamat;

public class GetWorkerInKhadamat : IGetWorkerInKhadamat
{
    private readonly IAppDbContext _context;
    public GetWorkerInKhadamat(IAppDbContext context)
    {
        context = _context;
    }

    public ResultDto<List<ResWK>> Execute(int workerId)
    {
        var wk = _context.WorkerInKhadamats.Where(w => w.WorkerId == workerId).Include(d => d.Worker).Include(t => t.Khadamat).ToList();


        List<ResWK> ResWKList = new List<ResWK>();


        foreach (var item in wk)
        {
            ResWKList.Add(new ResWK
            {
                WorkerName = item.Worker.FirstName + " " + item.Worker.LastName,
                KhadamatName = item.Khadamat.Name,
                KhadamatPrice = item.Khadamat.Price,
                KhadamatBonus = item.Bonus
            });
        }

        return new ResultDto<List<ResWK>>
        {
            IsSuccess = true,
            Message = "با موفقیت انجام شد",
            StatusCode = 200,
            Data = ResWKList
        };

    }

}





