using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Service.Histories.Queries;

public class HistoryDto
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime CrationDate { get; set; }
    public string ActionTitle { get; set; }
}
