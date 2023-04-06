using EmployeePortal.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal.Data.Services;

public class SqlEmployeeData: IEmployeeData
{
    private EmployeeDbContext _db;

    public SqlEmployeeData(EmployeeDbContext db)
    {
        _db = db;
    }
    public IEnumerable<Employee> GetAll()
    {
        return from e in _db.Employees
            orderby e.Name
            select e;
    }

    public Employee Get(int id)
    {
        return _db.Employees.FirstOrDefault(e => e.Id == id);
    }

    public void Add(Employee employee)
    {
        _db.Employees.Add(employee);
        _db.SaveChanges();
    }

    public void Update(Employee employee)
    {
        var entry = _db.Entry(employee);
        entry.State = EntityState.Modified;
    }

    public void Delete(int id)
    {
        var employee = _db.Employees.Find(id);
        if (employee != null) _db.Employees.Remove(employee);
        _db.SaveChanges();
    }
}