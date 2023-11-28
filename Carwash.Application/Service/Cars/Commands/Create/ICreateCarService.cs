using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Cars.Commands.Create;

public interface ICreateCarService
{
   Task<ResultDto<CreateCarDto>> Execute(CreateCarDto createCarDto);
}
