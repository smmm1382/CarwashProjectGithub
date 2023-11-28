using Carwash.Common.ResultDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Managers.Commands.Delete;

public interface IDeleteManagerService
{
    ResultDto Execute(int id);  
}
