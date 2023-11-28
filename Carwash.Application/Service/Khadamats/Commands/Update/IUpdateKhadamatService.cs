using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Khadamats.Commands.Update;

public interface IUpdateKhadamatService
{
   Task<ResultDto<UpdateKhadamatDto>> Execute(UpdateKhadamatDto updateKhadamatDto);
}
