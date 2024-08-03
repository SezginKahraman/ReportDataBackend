using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class EntraServicePrincipal
{
    public int DbSpid { get; set; }

    public string AzRoleId { get; set; } = null!;

    public string? AzName { get; set; }

    public string? AzAssignment { get; set; }

    public string? AzGroupId { get; set; }

    public string AzType { get; set; } = null!;

    public string? AzEnabled { get; set; }

    public string? AzLastActivated { get; set; }

    public string AzStatus { get; set; } = null!;

    public virtual EntraGroup? AzGroup { get; set; }

    public virtual EntraRole AzRole { get; set; } = null!;
}
