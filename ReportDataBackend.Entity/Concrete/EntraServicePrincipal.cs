using Core.Entity;
using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class EntraServicePrincipal : IEntity
{
    public string AzSpidId { get; set; }

    public string? AzName { get; set; }
    
    public string? AzUPN { get; set; }

    public string? AzAssignment { get; set; }

    public string AzType { get; set; } = null!;

    public string? AzEnabled { get; set; }

    public string? AzLastActivated { get; set; }

    public string AzStatus { get; set; } = null!;

    public virtual ICollection<ServicePrincipalGroupMapping> AzGroups { get; set; } = new List<ServicePrincipalGroupMapping>();

    public virtual ICollection<ServicePrincipalRoleMapping> AzRoles { get; set; } = new List<ServicePrincipalRoleMapping>();
}
