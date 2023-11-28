﻿using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Cars.Commands.Delete;

public interface IDeleteCarService
{
    Task<ResultDto> Execute(int id);
}
