using Core.DataAccess.EntityFramework;
using ReportDataBackend.DataAccess.Abstract;
using ReportDataBackend.Entity.Concrete;
using ReportDataBackend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ReportDataBackend.DataAccess.Concrete.EntityFramework
{
    public class EntraRoleDal : EfEntityRepositoryBase<EntraRole, ReportDataBackendContext>, IEntraRoleDal
    {
        public EntraRole? GetWithUsers(Expression<Func<EntraRole, bool>> filter = null)
        {
            using (ReportDataBackendContext context = new ReportDataBackendContext())
            {
                return filter == null ?
                    context.Set<EntraRole>().Include(t => t.EntraGroupAssignments).ThenInclude(t => t.AzGroup).Include(t => t.EntraUserAccounts).ThenInclude(t => t.DbUserAccount).SingleOrDefault(filter) : context.Set<EntraRole>().Include(t => t.EntraGroupAssignments).ThenInclude(t => t.AzGroup).Include(t => t.EntraUserAccounts).ThenInclude(t => t.DbUserAccount).SingleOrDefault(filter);
            }
        }

        public List<EntraRole> GetAllWithUsers(Expression<Func<EntraRole, bool>> filter = null)
        {
            using (ReportDataBackendContext context = new ReportDataBackendContext())
            {
                return filter == null ?
                    context.Set<EntraRole>().Include(t => t.EntraUserAccounts).ThenInclude(t => t.DbUserAccount).ToList() : context.Set<EntraRole>().Include(t => t.EntraUserAccounts).ThenInclude(t => t.DbUserAccount).Where(filter).ToList();
            }
        }

        public List<EntraRole> GetAll(int pageSize, int pageIndex, Expression<Func<EntraRole, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
