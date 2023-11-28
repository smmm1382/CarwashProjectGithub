using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Domain.Entities;

public class History
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime CrationDate { get; set; }
    public string ActionTitle { get; set; }

    //RelationShips
    public ICollection<WorkerInHistory> WorkerInHistory { get; set; }
    public ICollection<ManagerInHistory> ManagerInHistory { get; set; }
}
