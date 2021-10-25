using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateMVCAppliaction.Models
{
    public class CompanyContext: DbContext
    {
        public CompanyContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { Number = 101, Name = "Admin" });

            modelBuilder.Entity<Employee>().HasData(
               new Employee { EmployeeId = 1,Name="Raja",Age = 21,DepartmentNumber=101 });

            modelBuilder.Entity<Employee>().HasData(
               new Employee { EmployeeId = 2, Name = "Durai", Age = 21, DepartmentNumber = 101 });

        }
    }
}
