using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Domain.Entities;

public class WorkerInHistory
{
    public int Id { get; set; }

    //RelationShipsWorker
    public int WorkerId { get; set; }
    public Worker Worker { get; set; }

    //RelationShipsHistory
    public int HistoryId {  get; set; }
    public History History { get; set; }
}
