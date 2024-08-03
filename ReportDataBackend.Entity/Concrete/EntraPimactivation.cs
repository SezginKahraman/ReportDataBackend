using Core.Entity;
using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class EntraPimactivation : IEntity
{
    public int DbPimid { get; set; }

    public int DbUserAccountId { get; set; }

    public string AzRoleId { get; set; } = null!;

    public string AzStartTime { get; set; } = null!;

    public string AzEndTime { get; set; } = null!;

    public string? AzTicketSystem { get; set; }

    public string? AzTicketNumber { get; set; }

    public string? AzJustification { get; set; }

    public virtual EntraRole AzRole { get; set; } = null!;

    public virtual EntraUserAccount DbUserAccount { get; set; } = null!;
}
