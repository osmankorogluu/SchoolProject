using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ParentManager : IParentService
    {
        IParentDal _parentDal;

        public ParentManager(IParentDal parentDal)
        {
            _parentDal = parentDal;
        }

        public IResult Add(Parent parent)
        {
            _parentDal.Add(parent);
            return new SuccessResult(Messages.ParentAdded);
        }

        public IResult Delete(Parent parent)
        {
            _parentDal.Delete(parent);
            return new SuccessResult(Messages.ParentDeleted);
        }

        public IDataResult<List<Parent>> GetAll()
        {
            return new SuccessDataResult<List<Parent>>(_parentDal.GetAll(), Messages.ParentListed);
        }

        public IResult Update(Parent parent)
        {
            _parentDal.Update(parent);
            return new SuccessResult(Messages.ParentUpdated);
        }
    }
}
