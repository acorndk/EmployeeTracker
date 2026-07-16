using System;
using System.Collections.Generic;

namespace EmployeeTracker.Database;

public partial class Permission
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int StateId { get; set; }

    public string? Explanation { get; set; }

    public int Day { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual PermissionState State { get; set; } = null!;
}
