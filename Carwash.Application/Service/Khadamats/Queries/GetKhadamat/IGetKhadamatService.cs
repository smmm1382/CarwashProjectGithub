using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Khadamats.Queries.GetKhadamat;

public interface IGetKhadamatService
{
   Task<ResultDto<List<Khadamat>>> Execute();
}
