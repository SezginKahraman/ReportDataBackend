namespace ReportDataBackend.API.Models.Response
{
    public class EntraGroupModificationResponseModel
    {
        public int DbGroupModificationId { get; set; }

        public string AzGroupId { get; set; } = null!;

        public int DbUserAccountId { get; set; }

        public string AzInitiatedBy { get; set; } = null!;

        public string AzAction { get; set; } = null!;

        public string AzModifiedDate { get; set; } = null!;

        public virtual EntraGroupResponseModel AzGroup { get; set; } = null!;

        public virtual EntraUserAccountResponseModel DbUserAccount { get; set; } = null!;
    }
}
