using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2.Project
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string? Name { get; set; }

        public int EmployeeID{get;set;}
        public Employee.Employee? employee{get;set;}
    }
}