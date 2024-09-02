using Core.DataAccess.Abstract;
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
    public interface IEntraRoleDal : IEntityRepository<EntraRole>
    {
        public EntraRole? GetWithUsers(Expression<Func<EntraRole, bool>> filter = null);

        public List<EntraRole> GetAllWithUsers(Expression<Func<EntraRole, bool>> filter = null);
    }
}
