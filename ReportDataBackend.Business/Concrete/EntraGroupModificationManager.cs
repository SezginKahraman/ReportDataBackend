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
    public class EntraGroupModificationManager : IEntraGroupModificationService
    {
        private readonly IEntraGroupModificationDal _entraGroupModificationDal;

        public EntraGroupModificationManager(IEntraGroupModificationDal entraGroupModificationDal)
        {
            _entraGroupModificationDal = entraGroupModificationDal;
        }

        public IResult Add(EntraGroupModification t)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(EntraGroupModification t)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<EntraGroupModification>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<EntraGroupModification> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(EntraGroupModification t)
        {
            throw new NotImplementedException();
        }
    }
}
