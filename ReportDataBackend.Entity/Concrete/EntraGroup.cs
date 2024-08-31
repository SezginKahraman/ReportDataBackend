using Core.Entity;
using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class EntraGroup : IEntity
{
    public string AzGroupId { get; set; } = null!;

    public string AzGroupName { get; set; } = null!;

    public string? AzGroupsDescription { get; set; }

    public string? AzCreatedDate { get; set; }

    public DateTime DbModifiedDate { get; set; }

    public string AzStatus { get; set; } = null!;

    public virtual ICollection<EntraGroupAssignment> EntraGroupAssignments { get; set; } = new List<EntraGroupAssignment>();

    public virtual ICollection<EntraGroupModification> EntraGroupModifications { get; set; } = new List<EntraGroupModification>();

    public virtual ICollection<GroupRoleMapping> EntraUserAccounts { get; set; } = new List<GroupRoleMapping>();

    public virtual ICollection<ServicePrincipalGroupMapping> EntraServicePrincipals { get; set; } = new List<ServicePrincipalGroupMapping>();
}
