
using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStudentDal : EfEntityRepositoryBase<Student, SchoolDatabaseContext>, IStudentDal
    {
        public List<StudentDetailDto> GetStudentDetails()
        {
            using (SchoolDatabaseContext context = new SchoolDatabaseContext())
            {
                var result = from t in context.Teachers
                             join s in context.Students
                             on t.TeacherId equals s.TeacherId
                            

                           
                             select new StudentDetailDto
                             {
                                 StudentId = s.StudentId,
                                 TeacherName = t.Name,
                                 City = s.City,
                                 Class = s.Class,
                                 District = s.District,
                                 Gender = s.Gender,
                                 StudentName = s.Name,
                                 IdentificationNumber = s.IdentificationNumber,
                                 Phone = s.Phone,
                                 Section = s.Section,
                                 Surname = s.Surname

                             };
                return result.ToList();

            }

        }


    }
}
