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
    public class EntraRoleManager : IEntraRoleService
    {
        private readonly IEntraRoleDal _entraRoleDal;
        public EntraRoleManager(IEntraRoleDal entraRoleDal)
        {
            _entraRoleDal = entraRoleDal;
        }

        public IResult Add(EntraRole t)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(EntraRole t)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<EntraRole>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<EntraRole> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(EntraRole t)
        {
            throw new NotImplementedException();
        }
    }
}
