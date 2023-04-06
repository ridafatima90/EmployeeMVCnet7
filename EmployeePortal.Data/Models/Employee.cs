using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal.Data.Models;

public class Employee
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    public string? Gender { get; set; }
    [Required]
    [Precision(18, 2)]
    public decimal Salary { get; set; }
    [Display(Name="Mode of Employment")]
    public EmployeeType EmpType { get; set; }
}