using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Domain.Entities;

public class Khadamat
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    //RelationShip
    public ICollection<WorkerInKhadamat> WorkerInKhadamats { get; set; }
}
