using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Domain.Entities;

public class WorkerInKhadamat
{
    public int Id { get; set; }

    //RelationShipWorker
    public int WorkerId { get; set; }
    public Worker Worker { get; set; }

    //RelationShipKhadamat
    public int KhadamatId { get; set; }
    public Khadamat Khadamat { get; set; }
}
