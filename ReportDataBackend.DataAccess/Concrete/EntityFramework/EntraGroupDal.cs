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
using Microsoft.EntityFrameworkCore;

namespace ReportDataBackend.DataAccess.Concrete.EntityFramework
{
    public class EntraGroupDal : EfEntityRepositoryBase<EntraGroup, ReportDataBackendContext>, IEntraGroupDal
    {
        public List<EntraGroup> GetAll(int pageSize, int pageIndex, Expression<Func<EntraGroup, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public EntraGroup GetWithUsers(Expression<Func<EntraGroup, bool>> filter = null)
        {
            using (ReportDataBackendContext context = new ReportDataBackendContext())
            {
                return
                    context.Set<EntraGroup>().Include(t => t.EntraUserAccounts).ThenInclude(t => t.DbUserAccount).SingleOrDefault(filter);
            }
        }
    }
}
