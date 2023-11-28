using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Jwt;

public interface IJwtService
{
  ResultDto<string> Generate(LoginDto loginDto);
}
