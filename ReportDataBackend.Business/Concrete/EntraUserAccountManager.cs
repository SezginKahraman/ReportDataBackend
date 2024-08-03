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
            return new SuccessResult();
        }

        public IResult Delete(EntraUserAccount t)
        {
            return new SuccessResult();
        }

        public IDataResult<List<EntraUserAccount>> GetAll()
        {
            return new SuccessDataResult<List<EntraUserAccount>>(new List<EntraUserAccount>());
        }

        public IDataResult<EntraUserAccount> GetById(int id)
        {
            return new SuccessDataResult<EntraUserAccount>(new EntraUserAccount());
        }

        public IResult Update(EntraUserAccount t)
        {
            return new SuccessResult();
        }
    }
}
