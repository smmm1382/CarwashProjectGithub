using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Khadamats.Commands.Create;

public interface ICreateKhadamatService
{
   Task<ResultDto<CreateKhadamatDto>> Execute(CreateKhadamatDto createKhadamatDto);
}
