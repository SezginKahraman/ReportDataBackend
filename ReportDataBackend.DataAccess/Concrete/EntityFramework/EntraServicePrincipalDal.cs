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
    public class EntraServicePrincipalDal : EfEntityRepositoryBase<EntraServicePrincipal, ReportDataBackendContext>, IEntraServicePrincipalDal
    {
        public List<EntraServicePrincipal> GetAll(int pageSize, int pageIndex, Expression<Func<EntraServicePrincipal, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
