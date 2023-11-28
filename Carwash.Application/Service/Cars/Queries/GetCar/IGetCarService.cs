﻿using Carwash.Application.Interface;
using Carwash.Common.ResultDto;
using Carwash.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Cars.Queries.GetCar;

public interface IGetCarService
{
    ResultDto<ArrayList> Execute(CarListDto carListDto);
}
