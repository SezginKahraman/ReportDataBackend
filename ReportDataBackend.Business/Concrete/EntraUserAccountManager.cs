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
    public class EntraUserAccountManager : IEntraUserAccountService
    {
        private readonly IEntraUserAccountDal _entraUserAccountDal;
        public EntraUserAccountManager(IEntraUserAccountDal entraUserAccountDal)
        {
            _entraUserAccountDal = entraUserAccountDal;
        }
        public IResult Add(EntraUserAccount t)
        {
            _entraUserAccountDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(EntraUserAccount t)
        {
            _entraUserAccountDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<EntraUserAccount>> GetAll()
        {
            return new SuccessDataResult<List<EntraUserAccount>>(_entraUserAccountDal.GetAll());
        }

        public IDataResult<EntraUserAccount> GetById(int id)
        {
            return new SuccessDataResult<EntraUserAccount>(_entraUserAccountDal.Get(t => t.DbUserAccountId == id));
        }

        public IResult Update(EntraUserAccount t)
        {
            _entraUserAccountDal.Update(t);
            return new SuccessResult();
        }
    }
}
