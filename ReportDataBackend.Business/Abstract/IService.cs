using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDataBackend.Business.Abstract
{
    public interface IService<T>
    {
        IResult Add(T t);
        IResult Delete(T t);
        IResult Update(T t);
        IDataResult<T> GetById(int id);
        IDataResult<List<T>> GetAll();
    }
}
