using Carwash.Application.Service.Workers.Commands.Create;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Workers.Command.Create;

public interface ICreateWorkerService
{
   Task<ResultDto<CreateWorkerDto>> Execute(CreateWorkerDto createWorkerDto);
}
