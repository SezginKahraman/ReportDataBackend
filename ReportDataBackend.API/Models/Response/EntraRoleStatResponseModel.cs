using ReportDataBackend.Entity.Concrete;

namespace ReportDataBackend.API.Models.Response
{
    public class EntraRoleStatResponseModel
    {
        public int DbRSID { get; set; }

        public string AzRoleId { get; set; } = null!;

        public string RoleName { get; set; } 

        public DateTime DbModifiedDate { get; set; }

        public int Eligible { get; set; }

        public int Assigned { get; set; }

        public EntraRoleResponseModel AzRole { get; set; } = null!;
    }
}
