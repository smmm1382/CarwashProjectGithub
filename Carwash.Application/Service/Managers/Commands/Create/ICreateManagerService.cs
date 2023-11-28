using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Managers.Commands.Create;

public interface ICreateManagerService
{
    ResultDto<CreateManagerDto> Execute(CreateManagerDto createManagerDto);
}
