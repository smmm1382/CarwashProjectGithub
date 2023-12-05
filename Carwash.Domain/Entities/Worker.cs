using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Domain.Entities;

public class Worker
{
    public int? Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? Age { get; set; }
    public decimal? Salary { get; set; }
    public string? ImageFile { get; set; }
    public string? PhoneNumber { get; set; }

    //RelationShips
    public ICollection<WorkerInKhadamat> WorkerInKhadamats { get; set; }
    public ICollection<WorkerInHistory> WorkerInHistory { get; set; }
}
