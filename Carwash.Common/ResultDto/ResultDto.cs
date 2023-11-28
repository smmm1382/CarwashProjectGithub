using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Common.ResultDto;

public class ResultDto
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public int StatusCode { get; set; }
}

public class ResultDto<T> : ResultDto where T : class
{
    public T Data { get; set; }
}
