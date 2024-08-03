using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class EntraGroup
{
    public string AzGroupId { get; set; } = null!;

    public string AzGroupName { get; set; } = null!;

    public string? AzGroupsDescription { get; set; }

    public string? AzCreatedDate { get; set; }

    public DateTime DbModifiedDate { get; set; }

    public string AzStatus { get; set; } = null!;

    public virtual ICollection<EntraGroupAssignment> EntraGroupAssignments { get; set; } = new List<EntraGroupAssignment>();

    public virtual ICollection<EntraGroupModification> EntraGroupModifications { get; set; } = new List<EntraGroupModification>();

    public virtual ICollection<EntraServicePrincipal> EntraServicePrincipals { get; set; } = new List<EntraServicePrincipal>();

    public virtual ICollection<EntraUserAccount> EntraUserAccounts { get; set; } = new List<EntraUserAccount>();
}
