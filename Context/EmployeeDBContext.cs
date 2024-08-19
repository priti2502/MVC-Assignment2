using EFCoreAssignment.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAssignment.Context
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }
    }
}
