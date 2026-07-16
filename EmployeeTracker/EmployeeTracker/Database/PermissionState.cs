using System;
using System.Collections.Generic;

namespace EmployeeTracker.Database;

public partial class PermissionState
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
