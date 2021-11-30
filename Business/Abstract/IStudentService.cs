using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {
        IDataResult<List<Student>> GetAll();
        IDataResult<List<Student>> GetAllByTeacherId(int teacherId);
        IDataResult<List<StudentDetailDto>> GetStudentDetails();
        IResult Add(Student student);
        IResult Delete(Student student);
        IResult Update(Student student);

    }
}
