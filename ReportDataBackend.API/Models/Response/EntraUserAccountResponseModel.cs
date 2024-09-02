using ReportDataBackend.Entity.Concrete;

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

        public List<EntraGroupModification> EntraGroupModifications { get; set; } = new List<EntraGroupModification>();

        public List<EntraPimactivation> EntraPimactivations { get; set; } = new List<EntraPimactivation>();

        public List<EntraGroup> AzGroups { get; set; } = new List<EntraGroup>();

        public List<EntraRole> AzRoles { get; set; } = new List<EntraRole>();
    }
}
