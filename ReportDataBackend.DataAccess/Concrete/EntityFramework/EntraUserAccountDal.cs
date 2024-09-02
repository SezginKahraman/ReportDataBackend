using Core.DataAccess.EntityFramework;
using ReportDataBackend.DataAccess.Abstract;
using ReportDataBackend.Entity.Concrete;
using ReportDataBackend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ReportDataBackend.DataAccess.Concrete.EntityFramework
{
    public class EntraUserAccountDal : EfEntityRepositoryBase<EntraUserAccount, ReportDataBackendContext>, IEntraUserAccountDal
    {
        public EntraUserAccount? GetWithUsers(Expression<Func<EntraUserAccount, bool>> filter = null)
        {
            using (ReportDataBackendContext context = new ReportDataBackendContext())
            {
                return filter == null ?
                    context.Set<EntraUserAccount>().Include(t => t.AzRoles).ThenInclude(t => t.AzRole).SingleOrDefault(filter) : context.Set<EntraUserAccount>().Include(t => t.AzRoles).ThenInclude(t => t.AzRole).SingleOrDefault(filter);
            }
        }

        public List<EntraUserAccount> GetAllWithUsers(Expression<Func<EntraUserAccount, bool>> filter = null)
        {
            using (ReportDataBackendContext context = new ReportDataBackendContext())
            {
                return filter == null ?
                    context.Set<EntraUserAccount>().Include(t => t.AzRoles).ThenInclude(t => t.AzRole).ToList() : context.Set<EntraUserAccount>().Include(t => t.AzRoles).ThenInclude(t => t.AzRole).Where(filter).ToList();
            }
        }
    }
}
