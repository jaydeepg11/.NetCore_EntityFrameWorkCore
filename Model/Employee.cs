public class Employee
{
    public int EmployeeID { get; set; }
    public string? Name{get;set;}
    
    public ICollection<EmployeeProject>? employeeProjects {get;set;}
    public EmployeeDetail? employeeDetail{get;set;}

    public int TeamID{get;set;}
    public Team? team{get;set;}
}