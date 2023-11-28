using Carwash.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Application.Interface;

public interface IAppDbContext
{

    public DbSet<Worker> Workers { get; set; }
    public DbSet<Khadamat> Khadamats { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<History> Histories { get; set; }
    public DbSet<WorkerInKhadamat> WorkerInKhadamats { get; set; }
    public DbSet<ManagerInHistory> ManagerInHistories { get; set; }
    public DbSet<WorkerInHistory> WorkerInHistories { get; set; }


    int SaveChanges(bool acceptAllChangesOnSuccess);

    int SaveChanges();

    Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
}
