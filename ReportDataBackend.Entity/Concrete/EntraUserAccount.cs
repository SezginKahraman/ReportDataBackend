using Core.Entity;
using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class EntraUserAccount : IEntity
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

    public string AzObjectId { get; set; } = null!;

    public virtual ICollection<EntraGroupModification> EntraGroupModifications { get; set; } = new List<EntraGroupModification>();

    public virtual ICollection<EntraPimactivation> EntraPimactivations { get; set; } = new List<EntraPimactivation>();

    public virtual ICollection<GroupRoleMapping> AzGroups { get; set; } = new List<GroupRoleMapping>();

    public virtual ICollection<UserRoleMapping> AzRoles { get; set; } = new List<UserRoleMapping>();
}
