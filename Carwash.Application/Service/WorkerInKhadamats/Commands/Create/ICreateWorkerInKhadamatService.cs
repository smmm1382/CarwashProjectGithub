using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.WorkerInKhadamats.Commands.Create;

public interface ICreateWorkerInKhadamatService
{
    ResultDto Execute(CreateWorkerInKhadamatDto model);
}
