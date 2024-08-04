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
    public class EntraRoleManager : IEntraRoleService
    {
        private readonly IEntraRoleDal _entraRoleDal;
        public EntraRoleManager(IEntraRoleDal entraRoleDal)
        {
            _entraRoleDal = entraRoleDal;
        }

        public IResult Add(EntraRole t)
        {
            _entraRoleDal.Add(t);
            return new SuccessResult();
        }

        public IResult Delete(EntraRole t)
        {
            _entraRoleDal.Delete(t);
            return new SuccessResult();
        }

        public IDataResult<List<EntraRole>> GetAll()
        {
            return new SuccessDataResult<List<EntraRole>>(_entraRoleDal.GetAll());
        }

        public IDataResult<EntraRole> GetById(int id)
        {
            return new SuccessDataResult<EntraRole>(_entraRoleDal.Get(t => t.AzRoleId == id.ToString()));
        }

        public IResult Update(EntraRole t)
        {
            _entraRoleDal.Update(t);
            return new SuccessResult();
        }
    }
}
