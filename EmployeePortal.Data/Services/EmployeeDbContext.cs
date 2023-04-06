using EmployeePortal.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal.Data.Services;

public class EmployeeDbContext : DbContext
{
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
    {
    }
    public DbSet<Employee> Employees { get; set; }

}