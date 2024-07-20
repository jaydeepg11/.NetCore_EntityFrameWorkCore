
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2.EmployeeDetail
{
    public class EmployeeDetail
    {
        public int ID { get; set; }
        public string? Address{get;set;}
        public string? state {get;set;}
        public string? country{get;set;}
        public int EmployeeID{get;set;}
        public Employee.Employee? employee{get;set;}
    }
}