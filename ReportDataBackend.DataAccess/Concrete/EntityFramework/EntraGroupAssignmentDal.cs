using Core.DataAccess.EntityFramework;
using ReportDataBackend.DataAccess.Abstract;
using ReportDataBackend.Entity;
using ReportDataBackend.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDataBackend.DataAccess.Concrete.EntityFramework
{
    public class EntraGroupAssignmentDal : EfEntityRepositoryBase<EntraGroupAssignment, ReportDataBackendContext>, IEntraGroupAssignmentDal
    {
    }
}
