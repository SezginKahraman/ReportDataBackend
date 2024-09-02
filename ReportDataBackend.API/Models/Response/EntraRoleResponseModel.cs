namespace ReportDataBackend.API.Models.Response
{
    public class EntraRoleResponseModel
    {
        public string AzRoleId { get; set; } = null!;

        public string AzRoleName { get; set; } = null!;

        public string? AzRoleDescription { get; set; }

        public DateTime DbCreatedDate { get; set; }

        public DateTime DbModifiedDate { get; set; }

        public string AzStatus { get; set; } = null!;

        public List<EntraGroupAssignmentResponseModel>? EntraGroupAssignments { get; set; } = new List<EntraGroupAssignmentResponseModel>();

        public List<EntraPimactivationResponseModel>? EntraPimactivations { get; set; } = new List<EntraPimactivationResponseModel>();

        public List<EntraServicePrincipalResponseModel>? EntraServicePrincipals { get; set; } = new List<EntraServicePrincipalResponseModel>();

        public List<EntraUserAccountResponseModel>? EntraUserAccounts { get; set; } = new List<EntraUserAccountResponseModel>();
    }
}
