namespace ReportDataBackend.API.Models.Response
{
    public class EntraPimactivationResponseModel
    {
        public int DbPimid { get; set; }

        public int DbUserAccountId { get; set; }

        public string AzRoleId { get; set; } = null!;

        public string AzStartTime { get; set; } = null!;

        public string AzEndTime { get; set; } = null!;

        public string? AzTicketSystem { get; set; }

        public string? AzTicketNumber { get; set; }

        public string? AzJustification { get; set; }

        public EntraRoleResponseModel AzRole { get; set; } = null!;

        public EntraUserAccountResponseModel DbUserAccount { get; set; } = null!;
    }
}
