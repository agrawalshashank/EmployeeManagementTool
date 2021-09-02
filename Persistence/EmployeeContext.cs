using Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {

        }

        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EmployeeManagement;Integrated Security=True;Pooling=False"));
        }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<CompanyInfo> Company { get; set; }

    }
}
