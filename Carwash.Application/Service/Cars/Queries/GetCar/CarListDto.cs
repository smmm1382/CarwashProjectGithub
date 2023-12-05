using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Cars.Queries.GetCar;

public class CarListDto
{
    private int _Page = 1;
    public int Page
    {
        get
        {
            return _Page;
        }
        set
        {
            _Page = value;
        }
    }
    private int _PageSize = 5;
    public int PageSize
    {
        get
        {
            return _PageSize;
        }
        set
        {
            _PageSize = value;
        }
    }
}
