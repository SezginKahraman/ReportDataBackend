using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class EntraUserAccount
{
    public int DbUserAccountId { get; set; }

    public string? AzRoleId { get; set; }

    public string AzDisplayName { get; set; } = null!;

    public string AzUpn { get; set; } = null!;

    public string AzAssignment { get; set; } = null!;

    public string? AzGroupId { get; set; }

    public string AzType { get; set; } = null!;

    public string AzEnabled { get; set; } = null!;

    public string AzLastActivated { get; set; } = null!;

    public string AzStatus { get; set; } = null!;

    public virtual EntraGroup? AzGroup { get; set; }

    public virtual EntraRole? AzRole { get; set; }

    public virtual ICollection<EntraGroupModification> EntraGroupModifications { get; set; } = new List<EntraGroupModification>();

    public virtual ICollection<EntraPimactivation> EntraPimactivations { get; set; } = new List<EntraPimactivation>();
}
