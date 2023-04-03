using System.Collections;
using EmployeePortal.Data.Models;

namespace EmployeePortal.Data.Services;

public class InMemoryEmployeeData : IEmployeeData
{
    private List<Employee> Employees;

    public InMemoryEmployeeData()
    {
        Employees = new List<Employee>()
        {
            new Employee()
                { Id = 1, Name = "John Cena", EmployeeType = EmployeeType.FreeLancer, Gender = "Male", Salary = 10000 },
            new Employee()
                { Id = 2, Name = "Jane Cena", EmployeeType = EmployeeType.FullTime, Gender = "Female", Salary = 12000 },
            new Employee()
                { Id = 2, Name = "Martin Campbell", EmployeeType = EmployeeType.PartTime, Gender = "Male", Salary = 9000 },
        };
    }
    
    public IOrderedEnumerable<Employee> GetAll()
    {
        return Employees.OrderBy(e => e.Name);

    }
}