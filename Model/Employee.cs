using System.ComponentModel.DataAnnotations.Schema;
using Assignment2.EmployeeDetail;
namespace Assignment2.Employee
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string? Name { get; set; }
        public EmployeeDetail.EmployeeDetail? Detail{get;set;}
        public ICollection<Project.Project>? projects{get;set;}
    }
}