using System.ComponentModel.DataAnnotations;

namespace EmployeePortal.Data.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    [Required]
    public decimal Salary { get; set; }
    public EmployeeType EmployeeType { get; set; }
}