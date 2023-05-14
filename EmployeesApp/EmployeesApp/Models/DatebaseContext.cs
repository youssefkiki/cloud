using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeesApp.Models;

namespace EmployeesApp.Models
{
    public class DatebaseContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=MALAK\sqlexpress; initial catalog=StudentsDB; integrated security=SSPI;");


        }
    }
}
