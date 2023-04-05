using System.Collections;
using EmployeePortal.Data.Models;

namespace EmployeePortal.Data.Services;

public interface IEmployeeData
{
    IEnumerable<Employee> GetAll();
    Employee Get(int id);
    void Add(Employee employee);
    void Update(Employee employee);
    void Delete(int id);
}