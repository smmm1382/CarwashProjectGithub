using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Workers.Command.Update;

public class UpdateWorkerDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }
    public int Bonus { get; set; }
    public string? ImageFile { get; set; }
}
