using Carwash.Application.Interface;
using Carwash.Domain.Entities;
using CryptoHelper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carwash.Infrastructure.Context;

public class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }


    public DbSet<Worker> Workers { get; set; }
    public DbSet<Khadamat> Khadamats { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<History> Histories { get; set; }
    public DbSet<WorkerInKhadamat> WorkerInKhadamats { get; set; }
    public DbSet<ManagerInHistory> ManagerInHistories { get; set; }
    public DbSet<WorkerInHistory> WorkerInHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Worker>().HasData(new List<Worker>
        {
            new Worker{Id = 1,FirstName = "mahdi",LastName = "mousavi",Age = 20},
            new Worker{Id = 2,FirstName = "emaeil",LastName = "akbary",Age = 55},
            new Worker{Id = 3,FirstName = "amirhosein",LastName = "Khodabandelo",Age = 17}
        });


        modelBuilder.Entity<Khadamat>().HasData(new List<Khadamat>
        {
            new Khadamat{Id = 1,Name = "Roshoee",Price = 60000},
            new Khadamat{Id = 2,Name = "Broom",Price = 40000},
            new Khadamat{Id = 3,Name = "Wax",Price = 50000},
        });

        modelBuilder.Entity<Car>().HasData(new List<Car>
        {
            new Car{Id = 1,Name = "Pride"},
            new Car{Id = 2,Name = "Dena"},
            new Car{Id = 3,Name = "Arrizo"},
            new Car{Id = 4,Name = "Persia"},
            new Car{Id = 5,Name = "Peugeot405"},
            new Car{Id = 6,Name = "SurenPlus"},
            new Car{Id = 7,Name = "Samand"},
            new Car{Id = 8,Name = "Runu"},
            new Car{Id = 9,Name = "206"},
            new Car{Id = 10,Name = "207"},
            new Car{Id = 11,Name = "Tara"},
            new Car{Id = 12,Name = "SLX"},
            new Car{Id = 13,Name = "Shahin"},
            new Car{Id = 14,Name = "Optima"},
            new Car{Id = 15,Name = "Azera"},
        });

        modelBuilder.Entity<Manager>().HasData(new List<Manager>
        {
            new Manager{Id = 1,FirstName = "mahdi",LastName = "mousavi",Email = "mousavi@gmail.com",Password = Crypto.HashPassword( "12345")}
        });

        base.OnModelCreating(modelBuilder);
    }
}
