using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class EntraGroupAssignment
{
    public int DbGroupAssignmentId { get; set; }

    public string AzGroupId { get; set; } = null!;

    public string AzRoleId { get; set; } = null!;

    public string AzAssignmentType { get; set; } = null!;

    public string AzStatus { get; set; } = null!;

    public DateTime DbModifiedDate { get; set; }

    public virtual EntraGroup AzGroup { get; set; } = null!;

    public virtual EntraRole AzRole { get; set; } = null!;
}
