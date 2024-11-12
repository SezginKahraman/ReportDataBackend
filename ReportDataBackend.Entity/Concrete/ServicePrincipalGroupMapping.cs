using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class ServicePrincipalGroupMapping
{
    public int DbSpgroupId { get; set; }

    public string AzGroupId { get; set; } = null!;

    public string AzSpidId { get; set; }

    public DateTime DbAssignedDate { get; set; }

    public virtual EntraGroup AzGroup { get; set; } = null!;

    public virtual EntraServicePrincipal AzSp { get; set; } = null!;
}
