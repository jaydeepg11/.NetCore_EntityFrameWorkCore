

using Microsoft.EntityFrameworkCore;

public class EmployeeRepository : IEmployee
{
    ManageDbContext _context;
    public EmployeeRepository(ManageDbContext context)
    {
        _context=context;
    }

    public bool AddEmployee(Employee emp)
    {
        _context.Employees.Add(emp);
        _context.SaveChanges();
        return true;
    }

    public bool DeleteEmployee(int id)
    {   
        var emp=_context.Employees.Where(x=>x.EmployeeID==id).FirstOrDefault();
        _context.Employees.Remove(emp);
        _context.SaveChanges();
        return true;
    }

    public IEnumerable<Employee> getAll()
    {
        return _context.Employees.ToList();
    }

    public Employee GetEmployeesbyID(int? id)
    {
        return _context.Employees.Where(x=>x.EmployeeID==id).FirstOrDefault();
    }

    public bool updateEmloyee(Employee emp)
    {
        _context.Employees.Update(emp);
        _context.SaveChanges();
        return true;
    }
}