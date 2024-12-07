using Core.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using ReportDataBackend.DataAccess.Concrete.EntityFramework;
using ReportDataBackend.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReportDataBackend.DataAccess.Abstract
{
    public interface IEntraGroupDal : IEntityRepository<EntraGroup>
    {
        List<EntraGroup> GetAll(int pageSize, int pageIndex, Expression<Func<EntraGroup, bool>> filter = null);
        public EntraGroup GetWithUsers(Expression<Func<EntraGroup, bool>> filter = null);
    }
}
