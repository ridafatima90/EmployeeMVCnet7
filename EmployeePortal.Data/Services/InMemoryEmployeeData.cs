using EmployeePortal.Data.Models;

namespace EmployeePortal.Data.Services;

public class InMemoryEmployeeData : IEmployeeData
{
    private List<Employee> _employees;

    public InMemoryEmployeeData()
    {
        _employees = new List<Employee>()
        {
            new Employee
                { Id = 1, Name = "John Cena", EmpType = EmployeeType.FreeLancer, Gender = "Male", Salary = 13000 },
            new Employee
                { Id = 2, Name = "June Cena", EmpType = EmployeeType.FullTime, Gender = "Female", Salary = 12000 },
            new Employee
                { Id = 3, Name = "Martin Campbell", EmpType = EmployeeType.PartTime, Gender = "Male", Salary = 9000 },
        };
    }
    
    public IEnumerable<Employee> GetAll()
    {
        return _employees.OrderBy(e => e.Name);

    }

    public Employee Get(int id)
    {
        return _employees.FirstOrDefault(e => e.Id == id);
    }

    public void Add(Employee employee)
    {
        employee.Id = _employees.Max(e => e.Id) + 1;
        _employees.Add(employee);
    }

    public void Update(Employee employee)
    {
        var existing = Get(employee.Id);
        if (existing == null) return;
        existing.Name = employee.Name;
        existing.Gender = employee.Gender;
        existing.EmpType = employee.EmpType;
        existing.Salary = employee.Salary;
    }

    public void Delete(int id)
    {
        var employee = Get(id);
        if(employee != null)
         _employees.Remove(employee);
    }
}