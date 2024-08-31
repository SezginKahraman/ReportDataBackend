using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class UserRoleMapping
{
    public int DbUserRoleId { get; set; }

    public string AzRoleId { get; set; } = null!;

    public int DbUserAccountId { get; set; }

    public DateTime DbAssignedDate { get; set; }

    public virtual EntraRole AzRole { get; set; } = null!;

    public virtual EntraUserAccount DbUserAccount { get; set; } = null!;
}
