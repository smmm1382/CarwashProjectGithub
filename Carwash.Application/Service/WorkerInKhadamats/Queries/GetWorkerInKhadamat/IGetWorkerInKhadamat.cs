using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.WorkerInKhadamats.Queries.GetWorkerInKhadamat;

public interface IGetWorkerInKhadamat
{
    ResultDto<List<ResWK>> Execute(int workerId);
}
