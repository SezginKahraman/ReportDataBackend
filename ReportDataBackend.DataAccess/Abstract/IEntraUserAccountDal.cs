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
    public interface IEntraUserAccountDal : IEntityRepository<EntraUserAccount>
    {
        public EntraUserAccount? GetWithUsers(Expression<Func<EntraUserAccount, bool>> filter = null);

        public List<EntraUserAccount> GetAllWithUsers(Expression<Func<EntraUserAccount, bool>> filter = null);

        List<EntraUserAccount> GetAll(int pageSize, int pageIndex, Expression<Func<EntraUserAccount, bool>> filter = null);
    }
}
