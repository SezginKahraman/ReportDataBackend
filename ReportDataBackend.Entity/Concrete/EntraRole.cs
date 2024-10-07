using Core.Entity;
using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class EntraRole : IEntity
{
    public string AzRoleId { get; set; } = null!;

    public string AzRoleName { get; set; } = null!;

    public string? AzRoleDescription { get; set; }

    public DateTime DbCreatedDate { get; set; }

    public DateTime DbModifiedDate { get; set; }

    public string AzStatus { get; set; } = null!;

    public virtual ICollection<EntraGroupAssignment> EntraGroupAssignments { get; set; } = new List<EntraGroupAssignment>();

    public virtual ICollection<ServicePrincipalRoleMapping> EntraServicePrincipals { get; set; } = new List<ServicePrincipalRoleMapping>();

    public virtual ICollection<UserRoleMapping> EntraUserAccounts { get; set; } = new List<UserRoleMapping>();
}
