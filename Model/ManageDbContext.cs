using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class ManageDbContext:DbContext
{
    public ManageDbContext(DbContextOptions<ManageDbContext> options):base(options)
    {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeProject>().HasKey(key=>new {key.EmployeeID,key.ProjectID});
        modelBuilder.Entity<EmployeeProject>().HasOne(op=>op.employee).WithMany(op=>op.employeeProjects).HasForeignKey(key=>key.EmployeeID);
        modelBuilder.Entity<EmployeeProject>().HasOne(op=>op.project).WithMany(op=>op.employeeProjects).HasForeignKey(key=>key.ProjectID);

        modelBuilder.Entity<EmployeeDetail>().HasOne(op=>op.employee).WithOne(op=>op.employeeDetail).HasForeignKey<EmployeeDetail>(e => e.EmployeeID);

        modelBuilder.Entity<Employee>().HasOne(op=>op.team).WithMany(op=>op.employees).HasForeignKey(e => e.EmployeeID);

        modelBuilder.Entity<Employee>().HasData(new Employee{EmployeeID=1,Name="Abhishek",TeamID=1},new Employee{EmployeeID=2,Name="Basil",TeamID=2});
        modelBuilder.Entity<EmployeeDetail>().HasData(new EmployeeDetail{EmployeeDetailID=1,EmployeeID=1,Address="Maharashtra"},new EmployeeDetail{EmployeeDetailID=2,EmployeeID=2,Address="Goa"});
        modelBuilder.Entity<Project>().HasData(new Project{ProjectID=1,Name="Angular"},new Project{ProjectID=2,Name="Python"});
        modelBuilder.Entity<Team>().HasData(new Team{TeamID=1,TeamName="ICONS"},new Team{TeamID=2,TeamName="STRIKERS"});
        modelBuilder.Entity<EmployeeProject>().HasData(new EmployeeProject{EmployeeID=1,ProjectID=2},new EmployeeProject{EmployeeID=2,ProjectID=1});
    }
    public DbSet<Employee> Employees{get;set;}
    public DbSet<Project> Projects{get;set;}
    public DbSet<EmployeeProject> EmployeeProjects{get;set;}

    public DbSet<EmployeeDetail> EmployeeDetails{get;set;}
    public DbSet<Team> Teams{get;set;}
}  