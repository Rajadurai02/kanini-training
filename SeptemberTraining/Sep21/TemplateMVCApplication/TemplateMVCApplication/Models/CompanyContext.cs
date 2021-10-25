using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateMVCApplication.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department() { Id = 101, Name = "Admin" }
                );
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Tim", Age = 21, DepartmentId = 101 },
                new Employee() { Id = 2, Name = "Jim", Age = 29, DepartmentId = 101 }
                );
        }
    }
}
