using Carwash.Application.Service.Cars.Queries.GetCar;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Histories.Queries;

public interface IGetHistoryService
{
    ResultDto<List<History>> Execute();
}
    