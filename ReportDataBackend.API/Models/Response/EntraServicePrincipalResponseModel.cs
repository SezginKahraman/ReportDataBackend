namespace ReportDataBackend.API.Models.Response
{
    public class EntraServicePrincipalResponseModel
    {
        public int DbSpid { get; set; }

        public string AzRoleId { get; set; } = null!;

        public string? AzName { get; set; }

        public string? AzAssignment { get; set; }

        public string? AzGroupId { get; set; }

        public string AzType { get; set; } = null!;

        public string? AzEnabled { get; set; }

        public string? AzLastActivated { get; set; }

        public string AzStatus { get; set; } = null!;

        public List<EntraGroupResponseModel> AzGroups { get; set; } = new List<EntraGroupResponseModel>();

        public List<EntraRoleResponseModel> AzRoles { get; set; } = new List<EntraRoleResponseModel>();
    }
}
