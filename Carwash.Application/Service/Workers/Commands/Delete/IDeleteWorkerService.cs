using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Workers.Command.Delete;

public interface IDeleteWorkerService
{
   Task<ResultDto> Execute(int id);
}
