using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using ReportDataBackend.DataAccess.Abstract;
using ReportDataBackend.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReportDataBackend.DataAccess.Concrete.EntityFramework
{
    public class EntraRoleStatDal : EfEntityRepositoryBase<EntraRoleStat, ReportDataBackendContext>, IEntraRoleStatDal
    {
        public List<EntraRoleStat> GetAll(int pageSize, int pageIndex, Expression<Func<EntraRoleStat, bool>> filter = null)
        {
            using (ReportDataBackendContext context = new ReportDataBackendContext())
            {
                return filter == null ?
                    (
                       pageSize != 0 ? context.Set<EntraRoleStat>().Include(t => t.AzRole).Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize)
                        .ToList() : context.Set<EntraRoleStat>().Include(t => t.AzRole)
                        .ToList()) :
                    (
                        pageSize != 0 ?
                        context.Set<EntraRoleStat>().Include(t => t.AzRole).Where(filter).Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList() : context.Set<EntraRoleStat>().Include(t => t.AzRole).Where(filter).ToList()
                     );
            }
        }
    }
}
