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
    public class EntraGroupAssignmentManager : IEntraGroupAssignmentService
    {
        private readonly IEntraGroupAssignmentDal _entraGroupAssignmentDal;

        public EntraGroupAssignmentManager(IEntraGroupAssignmentDal entraGroupAssignmentDal)
        {
            _entraGroupAssignmentDal = entraGroupAssignmentDal;
        }

        public IResult Add(EntraGroupAssignment t)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(EntraGroupAssignment t)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<EntraGroupAssignment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<EntraGroupAssignment> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(EntraGroupAssignment t)
        {
            throw new NotImplementedException();
        }
    }
}
