using Core.Utilities.Results.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(EntraUserAccount t)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<EntraUserAccount>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<EntraUserAccount> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(EntraUserAccount t)
        {
            throw new NotImplementedException();
        }
    }
}
