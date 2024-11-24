using Core.DataAccess.Abstract;
using ReportDataBackend.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReportDataBackend.DataAccess.Abstract
{
    public interface IEntraGroupModificationDal : IEntityRepository<EntraGroupModification>
    {
        List<EntraGroupModification> GetAll(int pageSize, int pageIndex, Expression<Func<EntraGroupModification, bool>> filter = null);
    }
}
