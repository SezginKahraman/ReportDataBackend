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

        public IDataResult<List<EntraRole>> GetAll(bool withIncludes = false)
        {
            var relatedUsers = withIncludes ? _entraRoleDal.GetAllWithUsers() : _entraRoleDal.GetAll();
            if (relatedUsers == null)
            {
                return new ErrorDataResult<List<EntraRole>>("No role found with the given id.");
            }
            return new SuccessDataResult<List<EntraRole>>(relatedUsers);
        }

        public IDataResult<EntraRole> GetById(string id, bool withIncludes = false)
        {
            var relatedUser = withIncludes ? _entraRoleDal.GetWithUsers(t => t.AzRoleId == id) : _entraRoleDal.Get(t => t.AzRoleId == id);
            if(relatedUser == null)
            {
                return new ErrorDataResult<EntraRole>("No role found with the given id.");
            }
            return new SuccessDataResult<EntraRole>(relatedUser);
        }

        public IResult Update(EntraRole t)
        {
            _entraRoleDal.Update(t);
            return new SuccessResult();
        }
    }
}
