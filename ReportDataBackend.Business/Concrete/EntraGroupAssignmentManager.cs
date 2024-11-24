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
    public class EntraGroupAssignmentManager : IEntraGroupAssignmentService
    {
        private readonly IEntraGroupAssignmentDal _entraGroupAssignmentDal;

        public EntraGroupAssignmentManager(IEntraGroupAssignmentDal entraGroupAssignmentDal)
        {
            _entraGroupAssignmentDal = entraGroupAssignmentDal;
        }

        public IResult Add(EntraGroupAssignment t)
        {
            _entraGroupAssignmentDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(EntraGroupAssignment t)
        {
            _entraGroupAssignmentDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<EntraGroupAssignment>> GetAll(bool withIncludes = false, int pageSize = 0, int pageIndex = 0)
        {
            return new SuccessDataResult<List<EntraGroupAssignment>>(_entraGroupAssignmentDal.GetAll());
        }

        public IDataResult<EntraGroupAssignment> GetById(int id, bool withIncludes = false)
        {
            return new SuccessDataResult<EntraGroupAssignment>(_entraGroupAssignmentDal.Get(t => t.DbGroupAssignmentId == id));
        }

        public IResult Update(EntraGroupAssignment t)
        {
            _entraGroupAssignmentDal.Update(t);
            return new SuccessResult();
        }
    }
}
