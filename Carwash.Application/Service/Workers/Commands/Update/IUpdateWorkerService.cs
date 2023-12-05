using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Workers.Command.Update;

public interface IUpdateWorkerService
{
    Task<ResultDto<UpdateWorkerDto>> Execute(UpdateWorkerDto updateWorkerDto);
}
