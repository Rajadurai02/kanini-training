using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExampleFramework
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=KANINI-LTP-474\KANINISQLSERVER;Integrated Security=true;Initial Catalog=dbCompanyEFCF");
        }

        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding some data to data base
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                Id = 101,
                Name = "Raja",
                Age = 21
            });
        }
    }
}
