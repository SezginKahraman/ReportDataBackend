using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class GroupRoleMapping
{
    public int DbUserRoleId { get; set; }

    public string AzGroupId { get; set; } = null!;

    public int DbUserAccountId { get; set; }

    public DateTime DbAssignedDate { get; set; }

    public virtual EntraGroup AzGroup { get; set; } = null!;

    public virtual EntraUserAccount DbUserAccount { get; set; } = null!;
}
