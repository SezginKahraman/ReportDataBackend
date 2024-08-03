using Core.DataAccess.EntityFramework;
using ReportDataBackend.DataAccess.Abstract;
using ReportDataBackend.Entity.Concrete;
using ReportDataBackend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDataBackend.DataAccess.Concrete.EntityFramework
{
    public class EntraGroupModificationDal : EfEntityRepositoryBase<EntraGroupModification, ReportDataBackendContext>, IEntraGroupModificationDal
    {
    }
}
