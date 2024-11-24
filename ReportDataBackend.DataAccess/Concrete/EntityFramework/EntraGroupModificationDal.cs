using Core.DataAccess.EntityFramework;
using ReportDataBackend.DataAccess.Abstract;
using ReportDataBackend.Entity.Concrete;
using ReportDataBackend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ReportDataBackend.DataAccess.Concrete.EntityFramework
{
    public class EntraGroupModificationDal : EfEntityRepositoryBase<EntraGroupModification, ReportDataBackendContext>, IEntraGroupModificationDal
    {
        public List<EntraGroupModification> GetAll(int pageSize, int pageIndex, Expression<Func<EntraGroupModification, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
