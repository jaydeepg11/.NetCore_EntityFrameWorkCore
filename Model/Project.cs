public class Project
{
    public int ProjectID { get; set; }
    public string? Name { get; set; }

    public ICollection<EmployeeProject>? employeeProjects {get;set;}
}
