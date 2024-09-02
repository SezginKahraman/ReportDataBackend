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
    public class EntraPimactivationManager : IEntraPimactivationService
    {
        private readonly IEntraPimactivationDal _entraPimactivationDal;

        public EntraPimactivationManager(IEntraPimactivationDal entraPimactivationDal)
        {
            _entraPimactivationDal = entraPimactivationDal;
        }

        public IResult Add(EntraPimactivation t)
        {
            _entraPimactivationDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(EntraPimactivation t)
        {
            _entraPimactivationDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<EntraPimactivation>> GetAll(bool withIncludes = false)
        {
            return new SuccessDataResult<List<EntraPimactivation>>(_entraPimactivationDal.GetAll());
        }

        public IDataResult<EntraPimactivation> GetById(int id, bool withIncludes = false)
        {
            return new SuccessDataResult<EntraPimactivation>(_entraPimactivationDal.Get(t => t.DbPimid == id));
        }

        public IResult Update(EntraPimactivation t)
        {
            _entraPimactivationDal.Update(t);
            return new SuccessResult();
        }
    }
}
