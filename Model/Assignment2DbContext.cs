
using Assignment2.Roles;
using Assignment2.Employee;
using Assignment2.EmployeeDetail;
using Assignment2.Project;
using Microsoft.EntityFrameworkCore;
using Assignment2.EmployeeRoles;

public class Assignment2DbContext:DbContext
{
    public Assignment2DbContext(DbContextOptions<Assignment2DbContext> options):base(options)
    {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Employee> employees{get;set;}
    public DbSet<Project> projects{get;set;}

    public DbSet<EmployeeDetail> EmployeeDetails{get;set;}

    
    public DbSet<Roles> Roles{get;set;}

    public DbSet<EmployeeRoles> employeeRoles{get;set;}
}