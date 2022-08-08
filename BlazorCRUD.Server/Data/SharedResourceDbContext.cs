using BlazorCRUD.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.Server.Data
{
    public class SharedResourceDbContext : DbContext
    {
        protected SharedResourceDbContext(DbContextOptions<SharedResourceDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<SharedResourceModel> sharedResources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SharedResourceModel>().HasData(GetSharedResources());
            base.OnModelCreating(modelBuilder);
        }

        public IEnumerable<SharedResourceModel> GetSharedResources()
        {
            IEnumerable<SharedResourceModel> sharedResources = new List<SharedResourceModel>()
            {
                new() { Name = "Shared 01", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 10, AllocationMemory = 25, CreateDate  = Convert.ToDateTime("2022-08-01"), ExpriedDate  = Convert.ToDateTime("2022-08-14")  },
                new() { Name = "Shared 02", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 15, AllocationMemory = 40, CreateDate  = Convert.ToDateTime("2022-08-02"), ExpriedDate  = Convert.ToDateTime("2022-08-15")  },
                new() { Name = "Shared 03", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 30, AllocationMemory = 25, CreateDate  = Convert.ToDateTime("2022-08-03"), ExpriedDate  = Convert.ToDateTime("2022-08-16")  },
                new() { Name = "Shared 04", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 25, AllocationMemory = 15, CreateDate  = Convert.ToDateTime("2022-08-04"), ExpriedDate  = Convert.ToDateTime("2022-08-17")  },
                new() { Name = "Shared 05", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 25, AllocationMemory = 56, CreateDate  = Convert.ToDateTime("2022-08-05"), ExpriedDate  = Convert.ToDateTime("2022-08-18")  },
                new() { Name = "Shared 06", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 16, AllocationMemory = 22, CreateDate  = Convert.ToDateTime("2022-08-06"), ExpriedDate  = Convert.ToDateTime("2022-08-19")  },
                new() { Name = "Shared 07", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 25, AllocationMemory = 98, CreateDate  = Convert.ToDateTime("2022-08-07"), ExpriedDate  = Convert.ToDateTime("2022-08-20")  },
                new() { Name = "Shared 08", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 25, AllocationMemory = 17, CreateDate  = Convert.ToDateTime("2022-08-08"), ExpriedDate  = Convert.ToDateTime("2022-08-21")  },
                new() { Name = "Shared 09", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 25, AllocationMemory = 35, CreateDate  = Convert.ToDateTime("2022-08-09"), ExpriedDate  = Convert.ToDateTime("2022-08-22")  },
                new() { Name = "Shared 10", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 27, AllocationMemory = 67, CreateDate  = Convert.ToDateTime("2022-08-10"), ExpriedDate  = Convert.ToDateTime("2022-08-23")  },
                new() { Name = "Shared 11", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 98, AllocationMemory = 90, CreateDate  = Convert.ToDateTime("2022-08-11"), ExpriedDate  = Convert.ToDateTime("2022-08-24")  },
                new() { Name = "Shared 12", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 07, AllocationMemory = 05, CreateDate  = Convert.ToDateTime("2022-08-12"), ExpriedDate  = Convert.ToDateTime("2022-08-25")  },
                new() { Name = "Shared 13", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 34, AllocationMemory = 61, CreateDate  = Convert.ToDateTime("2022-08-13"), ExpriedDate  = Convert.ToDateTime("2022-08-26")  },
                new() { Name = "Shared 14", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 58, AllocationMemory = 78, CreateDate  = Convert.ToDateTime("2022-08-14"), ExpriedDate  = Convert.ToDateTime("2022-08-27")  },
                new() { Name = "Shared 15", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 98, AllocationMemory = 89, CreateDate  = Convert.ToDateTime("2022-08-15"), ExpriedDate  = Convert.ToDateTime("2022-08-28")  },
                new() { Name = "Shared 16", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 99, AllocationMemory = 12, CreateDate  = Convert.ToDateTime("2022-08-16"), ExpriedDate  = Convert.ToDateTime("2022-08-19")  },
                new() { Name = "Shared 17", Description ="Test", LimitCpu = 100, LimitMemory = 100, AllocationCpu = 11, AllocationMemory = 17, CreateDate  = Convert.ToDateTime("2022-08-17"), ExpriedDate  = Convert.ToDateTime("2022-08-30")  },
            };

            return sharedResources;
        }
    }
}
