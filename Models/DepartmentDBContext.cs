using Microsoft.EntityFrameworkCore;

namespace Thithuchanh.Models
{
    public class DepartmentDBContext : DbContext
    {
        public DepartmentDBContext(DbContextOptions<DepartmentDBContext> options ) : base( options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
  
}
