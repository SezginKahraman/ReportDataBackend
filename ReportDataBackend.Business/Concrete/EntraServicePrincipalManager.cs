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
    public class EntraServicePrincipalManager : IEntraServicePrincipalService
    {
        private readonly IEntraServicePrincipalDal _entraServicePrincipalDal;

        public EntraServicePrincipalManager(IEntraServicePrincipalDal entraServicePrincipalDal)
        {
            _entraServicePrincipalDal = entraServicePrincipalDal;
        }

        public IResult Add(EntraServicePrincipal t)
        {
            _entraServicePrincipalDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(EntraServicePrincipal t)
        {
            _entraServicePrincipalDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<EntraServicePrincipal>> GetAll(bool withIncludes = false, int pageSize = 0, int pageIndex = 0)
        {
            return new SuccessDataResult<List<EntraServicePrincipal>>(_entraServicePrincipalDal.GetAll());
        }

        public IDataResult<EntraServicePrincipal> GetById(string id, bool withIncludes = false)
        {
            return new SuccessDataResult<EntraServicePrincipal>(_entraServicePrincipalDal.Get(t => t.AzSpidId == id));
        }

        public IResult Update(EntraServicePrincipal t)
        {
            _entraServicePrincipalDal.Update(t);
            return new SuccessResult();
        }
    }
}
