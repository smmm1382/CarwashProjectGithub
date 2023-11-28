using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Domain.Entities;

public class ManagerInHistory
{
    public int Id { get; set; }

    //RelationShipManager
    public int ManagerId { get; set; }
    public Manager Manager { get; set; }

    //RelationShipHistory
    public int HistoryId { get; set; }
    public History History { get; set; }
}
