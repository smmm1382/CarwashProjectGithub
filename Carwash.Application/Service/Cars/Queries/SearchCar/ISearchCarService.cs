using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Cars.Queries.SearchCar;

public interface ISearchCarService
{
    Task<ResultDto<List<Car>>> Execute(SearchCarDto searchCarDto);
}
