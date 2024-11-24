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
    public class EntraGroupManager : IEntraGroupService
    {
        private readonly IEntraGroupDal _entraGroupDal;

        public EntraGroupManager(IEntraGroupDal entraGroupDal)
        {
            _entraGroupDal = entraGroupDal;
        }

        public IResult Add(EntraGroup t)
        {
            _entraGroupDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(EntraGroup t)
        {
            _entraGroupDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<EntraGroup>> GetAll(bool withIncludes = false, int pageSize = 0, int pageIndex = 0)
        {
            return new SuccessDataResult<List<EntraGroup>>(_entraGroupDal.GetAll());
        }

        public IDataResult<EntraGroup> GetById(string id, bool withIncludes = false)
        {
            return new SuccessDataResult<EntraGroup>(_entraGroupDal.Get(t => t.AzGroupId == id));
        }

        public IResult Update(EntraGroup t)
        {
            _entraGroupDal.Update(t);
            return new SuccessResult();
        }
    }
}
