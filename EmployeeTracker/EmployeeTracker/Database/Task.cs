using System;
using System.Collections.Generic;

namespace EmployeeTracker.Database;

public partial class Task
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public int StateId { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual TaskState State { get; set; } = null!;
}
