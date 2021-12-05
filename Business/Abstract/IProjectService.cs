﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IProjectService
    {
        IDataResult<List<Project>> GetAll();
        IResult Add(Project project);
        IResult Delete(Project project);
        IResult Update(Project project);
    }
}
