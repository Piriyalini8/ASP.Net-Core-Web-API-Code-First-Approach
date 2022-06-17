using CodeFirstWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CodeFirstWebAPI.DBContext
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Priyalini",
                LastName = "Niththiyanantham",
                Email = "priyalini8@gmail.com",
                DateOfBirth = new DateTime(1997, 05, 26),
                PhoneNumber = "076-888-7777"
            }, new Employee
            {
                EmployeeId = 2,
                FirstName = "Kishan",
                LastName = "Vadivel",
                Email = "kishanv@gmail.com",
                DateOfBirth = new DateTime(1997, 05, 09),
                PhoneNumber = "076-222-3333"
            });
        }
    }
}
