using System.Collections;
using EmployeePortal.Data.Models;

namespace EmployeePortal.Data.Services;

public interface IEmployeeData
{
    IOrderedEnumerable<Employee> GetAll();
}