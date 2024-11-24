using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using ReportDataBackend.Business.Abstract;
using ReportDataBackend.DataAccess.Abstract;
using ReportDataBackend.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDataBackend.Business.Concrete
{
    public class EntraRoleStatManager : IEntraRoleStatService
    {
        private readonly IEntraRoleStatDal _entraRoleStatDal;

        public EntraRoleStatManager(IEntraRoleStatDal entraRoleStatService)
        {
            _entraRoleStatDal = entraRoleStatService;
        }

        public IResult Add(EntraRoleStat t)
        {
            _entraRoleStatDal.Add(t);
            return new SuccessResult(); 
        }

        public IResult Delete(EntraRoleStat t)
        {
            _entraRoleStatDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<EntraRoleStat>> GetAll(bool withIncludes = false, int pageSize = 0, int pageIndex = 0)
        {
            return new SuccessDataResult<List<EntraRoleStat>>(_entraRoleStatDal.GetAll(pageSize:pageSize, pageIndex:pageIndex));
        }

        public IDataResult<EntraRoleStat> GetById(int id, bool withIncludes = false)
        {
            return new SuccessDataResult<EntraRoleStat>(_entraRoleStatDal.Get(t => t.DbRSID == id));
        }

        public IResult Update(EntraRoleStat t)
        {
            _entraRoleStatDal.Update(t);
            return new SuccessResult();
        }
    }
}
