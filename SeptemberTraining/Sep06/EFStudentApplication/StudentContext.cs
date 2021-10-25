using EFStudentApplication;
using Microsoft.EntityFrameworkCore;
using System;


namespace EFExampleFramework
{
    public class StudentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connect to the server
            optionsBuilder.UseSqlServer(@"Data source=KANINI-LTP-474\KANINISQLSERVER;Integrated Security=true;Initial Catalog=Day13Question");
        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding some data to data base
            modelBuilder.Entity<Student>().HasData(new Student()
            {
                Id = 101,
                Name = "Arun",
                DateOfJoining = "13-08-2021"
            });
            modelBuilder.Entity<Student>().HasData(new Student()
            {
                Id = 103,
                Name = "Ajay",
                DateOfJoining = "13-08-2021"
            });
            modelBuilder.Entity<Student>().HasData(new Student()
            {
                Id = 104,
                Name = "Ashok",
                DateOfJoining = "13-08-2021"
            });
        }

    }
}

