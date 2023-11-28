using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Khadamats.Commands.SaveKhadamat;

public interface ISaveKhadamatService
{
  Task<ResultDto<SaveKhadamatDto>> Execute(SaveKhadamatDto saveKhadamatDto);
}
