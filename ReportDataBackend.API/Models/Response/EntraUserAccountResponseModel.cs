namespace ReportDataBackend.API.Models.Response
{
    public class EntraUserAccountResponseModel
    {
        public int DbUserAccountId { get; set; }

        public string? AzRoleId { get; set; }

        public string AzDisplayName { get; set; } = null!;

        public string AzUpn { get; set; } = null!;

        public string AzAssignment { get; set; } = null!;

        public string? AzGroupId { get; set; }

        public string AzType { get; set; } = null!;

        public string AzEnabled { get; set; } = null!;

        public string AzLastActivated { get; set; } = null!;

        public string AzStatus { get; set; } = null!;

        public List<EntraGroupModificationResponseModel>? EntraGroupModifications { get; set; } = new List<EntraGroupModificationResponseModel>();

        public List<EntraPimactivationResponseModel>? EntraPimactivations { get; set; } = new List<EntraPimactivationResponseModel>();

        public List<EntraGroupResponseModel>? AzGroups { get; set; } = new List<EntraGroupResponseModel>();

        public List<EntraRoleResponseModel>? AzRoles { get; set; } = new List<EntraRoleResponseModel>();
    }
}
