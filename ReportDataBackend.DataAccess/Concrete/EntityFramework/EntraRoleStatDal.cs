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
    }
}
