using Core.Entity;
using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class EntraGroupModification : IEntity
{
    public int DbGroupModificationId { get; set; }

    public string AzGroupId { get; set; } = null!;

    public int DbUserAccountId { get; set; }

    public string AzInitiatedBy { get; set; } = null!;

    public string AzAction { get; set; } = null!;

    public string AzModifiedDate { get; set; } = null!;

    public virtual EntraGroup AzGroup { get; set; } = null!;

    public virtual EntraUserAccount DbUserAccount { get; set; } = null!;
}
