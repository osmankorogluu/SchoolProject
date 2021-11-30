using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryStudentDal : IStudentDal
    {
        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public Student Get(Expression<Func<Student, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll(Expression<Func<Student, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<StudentDetailDto> GetStudentDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
