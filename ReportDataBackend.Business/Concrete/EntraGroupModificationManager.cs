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
    public class EntraGroupModificationManager : IEntraGroupModificationService
    {
        private readonly IEntraGroupModificationDal _entraGroupModificationDal;

        public EntraGroupModificationManager(IEntraGroupModificationDal entraGroupModificationDal)
        {
            _entraGroupModificationDal = entraGroupModificationDal;
        }

        public IResult Add(EntraGroupModification t)
        {
            _entraGroupModificationDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(EntraGroupModification t)
        {
            _entraGroupModificationDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<EntraGroupModification>> GetAll(bool withIncludes = false, int pageSize = 0, int pageIndex = 0)
        {
            return new SuccessDataResult<List<EntraGroupModification>>(_entraGroupModificationDal.GetAll());
        }

        public IDataResult<EntraGroupModification> GetById(int id, bool withIncludes = false)
        {
            return new SuccessDataResult<EntraGroupModification>(_entraGroupModificationDal.Get(t => t.DbGroupModificationId == id));
        }

        public IResult Update(EntraGroupModification t)
        {
            _entraGroupModificationDal.Update(t);
            return new SuccessResult();
        }
    }
}
