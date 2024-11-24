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
    public interface IEntraPimactivationDal : IEntityRepository<EntraPimactivation>
    {
        List<EntraPimactivation> GetAll(int pageSize, int pageIndex, Expression<Func<EntraPimactivation, bool>> filter = null);
    }
}
