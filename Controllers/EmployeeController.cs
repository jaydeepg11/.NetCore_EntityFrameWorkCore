using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

[Route("api/Employee")]
public class EmployeeController : ControllerBase
{

    public ManageDbContext _context;
    public IEmployee _emp;
    public EmployeeController(ManageDbContext context,IEmployee emp)
    {
        _context=context;
        _emp=emp;
    }
    [EnableCors("CorsPolicy")]
    [Route("getEmployee/{id?}")]
    [HttpGet]
    public IActionResult getEmployee(int? id)
    {   
        if(_emp!=null)
        {
        if(id==null || id==0)
        {
            return Ok(_emp.getAll());
        }else
            return Ok(_emp.GetEmployeesbyID(id));
        }
        else
            return NotFound();
    }

[EnableCors("CorsPolicy")]
    [HttpPut]
    [Route("updateEmployee")]
     public IActionResult updateEmployee(Employee emp)
    {   
        if(_emp!=null)
        {
            Console.WriteLine(emp.EmployeeID+" | "+emp.Name+" | "+emp.TeamID);
            _emp.updateEmloyee(emp);
            return Ok();
        }
        else
        return NoContent();
    }

    [HttpDelete]
    [Route("deleteEmployee/{id?}")]
     public IActionResult deleteEmployee(int id)
    {   
        if(_emp!=null)
        {
            _emp.DeleteEmployee(id);
            return Ok();
        }
        else
        return NoContent();
    }

    [HttpPost]
    [Route("addEmployee")]
     public IActionResult addEmployee(Employee emp)
    {   
        // Employee emp2=new Employee(){
        //     EmployeeID=2,
        //     Name="Basil",
        //     TeamID=1
        // };
        if(_emp!=null)
        {
            Console.WriteLine(emp.EmployeeID+" | "+emp.Name+" | "+emp.TeamID);
            _emp.AddEmployee(emp);
            return Ok();
        }
        else
        return NoContent();
    }
}