﻿using Core.Entity;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDataBackend.Business.Abstract
{
    public interface IService<TEntity, TTypeOfEntityId>
    {
        IResult Add(TEntity t);
        IResult Delete(TEntity t);
        IResult Update(TEntity t);
        IDataResult<TEntity> GetById(TTypeOfEntityId id, bool withIncludes = false);
        IDataResult<List<TEntity>> GetAll(bool withIncludes = false, int pageSize = 0, int pageIndex = 0);
    }
}
