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

        public IDataResult<List<EntraUserAccount>> GetAll(bool withIncludes = false, int pageSize = 0, int pageIndex = 0)
        {
            var relatedAccounts = withIncludes ? _entraUserAccountDal.GetAllWithUsers() : _entraUserAccountDal.GetAll();

            if (relatedAccounts == null)
            {
                return new ErrorDataResult<List<EntraUserAccount>>("No role found with the given id.");
            }
            return new SuccessDataResult<List<EntraUserAccount>>(relatedAccounts);
        }

        public IDataResult<EntraUserAccount> GetById(int id, bool withIncludes = false)
        {
            var relatedAccount = withIncludes ? _entraUserAccountDal.GetWithUsers(t => t.DbUserAccountId == id) : _entraUserAccountDal.Get(t => t.DbUserAccountId == id);

            if (relatedAccount == null)
            {
                return new ErrorDataResult<EntraUserAccount>("No role found with the given id.");
            }

            return new SuccessDataResult<EntraUserAccount>(relatedAccount);
        }
        public IResult Update(EntraUserAccount t)
        {
            _entraUserAccountDal.Update(t);
            return new SuccessResult();
        }
    }
}
