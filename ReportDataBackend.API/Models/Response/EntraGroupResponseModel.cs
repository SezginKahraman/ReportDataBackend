namespace ReportDataBackend.API.Models.Response
{
    public class EntraGroupResponseModel
    {
        public string AzGroupId { get; set; } = null!;

        public string AzGroupName { get; set; } = null!;

        public string? AzGroupsDescription { get; set; }

        public string? AzCreatedDate { get; set; }

        public DateTime? DbModifiedDate { get; set; }

        public string AzStatus { get; set; } = null!;

        public List<EntraServicePrincipalResponseModel> EntraGroupAssignments { get; set; } = new List<EntraServicePrincipalResponseModel>();
        
        public List<EntraGroupModificationResponseModel> EntraGroupModifications { get; set; } = new List<EntraGroupModificationResponseModel>();
       
        public List<EntraUserAccountResponseModel> EntraUserAccounts { get; set; } = new List<EntraUserAccountResponseModel>();
          
        public List<EntraServicePrincipalResponseModel> EntraServicePrincipals { get; set; } = new List<EntraServicePrincipalResponseModel>();
    }
}
