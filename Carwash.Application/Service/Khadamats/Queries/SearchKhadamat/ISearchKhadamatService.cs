using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Khadamats.Queries.SearchKhadamat;

public interface ISearchKhadamatService
{
    ResultDto<List<Khadamat>> Execute(SearchKhadamatDto searchKhadamatDto);
}
