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
    public class EntraGroupManager : IEntraGroupService
    {
        private readonly IEntraGroupDal _entraGroupDal;

        public EntraGroupManager(IEntraGroupDal entraGroupDal)
        {
            _entraGroupDal = entraGroupDal;
        }

        public IResult Add(EntraGroup t)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(EntraGroup t)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<EntraGroup>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<EntraGroup> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(EntraGroup t)
        {
            throw new NotImplementedException();
        }
    }
}
