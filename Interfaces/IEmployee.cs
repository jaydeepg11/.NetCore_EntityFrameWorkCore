
public interface IEmployee
{
    IEnumerable<Employee> getAll();
    Employee GetEmployeesbyID(int? id);
    bool AddEmployee(Employee emp);
    bool DeleteEmployee(int id);
    bool updateEmloyee(Employee emp);
}