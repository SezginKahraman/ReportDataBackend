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
    public class EntraServicePrincipalManager : IEntraServicePrincipalService
    {
        private readonly IEntraServicePrincipalDal _entraServicePrincipalDal;

        public EntraServicePrincipalManager(IEntraServicePrincipalDal entraServicePrincipalDal)
        {
            _entraServicePrincipalDal = entraServicePrincipalDal;
        }

        public IResult Add(EntraServicePrincipal t)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(EntraServicePrincipal t)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<EntraServicePrincipal>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<EntraServicePrincipal> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(EntraServicePrincipal t)
        {
            throw new NotImplementedException();
        }
    }
}
