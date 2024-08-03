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
    public class EntraPimactivationManager : IEntraPimactivationService
    {
        private readonly IEntraPimactivationDal _entraPimactivationDal;

        public EntraPimactivationManager(IEntraPimactivationDal entraPimactivationDal)
        {
            _entraPimactivationDal = entraPimactivationDal;
        }

        public IResult Add(EntraPimactivation t)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(EntraPimactivation t)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<EntraPimactivation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<EntraPimactivation> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(EntraPimactivation t)
        {
            throw new NotImplementedException();
        }
    }
}
