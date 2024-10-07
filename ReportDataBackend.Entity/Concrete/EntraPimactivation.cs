using Core.Entity;
using System;
using System.Collections.Generic;

namespace ReportDataBackend.Entity.Concrete;

public partial class EntraPimactivation : IEntity
{
    public int DbPimid { get; set; }

    public int DbUserAccountId { get; set; }

    public DateTime AzStartTime { get; set; } 

    public DateTime AzEndTime { get; set; }

    public string? AzTicketSystem { get; set; }

    public string? AzTicketNumber { get; set; }

    public string? AzJustification { get; set; }

    public virtual EntraUserAccount DbUserAccount { get; set; } = null!;
}
