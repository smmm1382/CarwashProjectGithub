using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Workers.Command.SaveWorker;

public interface ISaveWorkerService
{
   Task<ResultDto<SaveWorkerDto>> Execute(SaveWorkerDto saveWorkerDto);
}
