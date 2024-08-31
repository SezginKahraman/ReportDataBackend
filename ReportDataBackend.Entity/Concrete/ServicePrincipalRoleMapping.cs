using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class ServicePrincipalRoleMapping
{
    public int DbSproleId { get; set; }

    public string AzRoleId { get; set; } = null!;

    public int AzSpid { get; set; }

    public DateTime DbAssignedDate { get; set; }

    public virtual EntraRole AzRole { get; set; } = null!;

    public virtual EntraServicePrincipal AzSp { get; set; } = null!;
}
