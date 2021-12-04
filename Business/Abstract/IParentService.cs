using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IParentService
    {
        IDataResult<List<Parent>> GetAll();
        IResult Add(Parent parent);
        IResult Delete(Parent parent);
        IResult Update(Parent parent);
    }
}
