using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KendoUI.Domain;

namespace KendoUI.Persistence
{
    public class EmployeeDbContext: KendoContext<EmployeeDbContext> 
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Salary> Salaries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
