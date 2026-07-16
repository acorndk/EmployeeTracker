using System;
using System.Collections.Generic;

namespace EmployeeTracker.Database;

public partial class Month
{
    public int Id { get; set; }

    public string MonthName { get; set; } = null!;

    public virtual ICollection<Salary> Salaries { get; set; } = new List<Salary>();
}
