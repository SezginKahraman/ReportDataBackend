using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDataBackend.Entity.Concrete
{
    public partial class EntraRoleStat : IEntity
    {
        public int DbRSID { get; set; }

        public string AzRoleId { get; set; } = null!;

        public DateTime DbModifiedDate { get; set; }

        public int Eligible { get; set; }

        public int Assigned { get; set; }

        public virtual EntraRole AzRole { get; set; } = null!;
    }
}
