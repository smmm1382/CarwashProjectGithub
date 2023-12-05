using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.WorkerInKhadamats.Commands.Create;

public class CreateWorkerInKhadamatService : ICreateWorkerInKhadamatService
{
    private readonly IAppDbContext _context;
    public CreateWorkerInKhadamatService(IAppDbContext context)
    {
        _context = context;
    }

    public ResultDto Execute(CreateWorkerInKhadamatDto model)
    {
        WorkerInKhadamat workerInKhadamat = new WorkerInKhadamat()
        {
            WorkerId = model.WorkerId,
            KhadamatId = model.KhadamatId,
            Bonus = model.Bouns,
        };

        _context.WorkerInKhadamats.Add(workerInKhadamat);
        _context.SaveChanges();

        return new ResultDto
        {
            IsSuccess = true,
            Message = "با موفقیت انجام شد",
            StatusCode = 200
        };
       
        
    }
}
