namespace Assignment2.EmployeeRoles
{
    public class EmployeeRoles{
        public int EmployeeRolesID{get;set;}
        public int EmployeeID { get; set; }
        public int RoleID {get;set;}

        public ICollection<Employee.Employee>? employees{get;set;}
        public ICollection<Roles.Roles>? Roles{get;set;}
    }
}