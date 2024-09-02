namespace ReportDataBackend.API.Models.Response
{
    public class EntraGroupAssignmentResponseModel
    {
        public int DbGroupAssignmentId { get; set; }

        public string AzGroupId { get; set; } = null!;

        public string AzRoleId { get; set; } = null!;

        public string AzAssignmentType { get; set; } = null!;

        public string AzStatus { get; set; } = null!;

        public DateTime DbModifiedDate { get; set; }

        public EntraGroupResponseModel AzGroup { get; set; } = null!;

        public EntraRoleResponseModel AzRole { get; set; } = null!;
    }
}
