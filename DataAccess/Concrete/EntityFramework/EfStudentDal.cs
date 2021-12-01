
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
                var result = from c in context.Students
                             join b in context.Teachers
                             on c.TeacherId equals b.TeacherId


                             select new StudentDetailDto
                             {
                                 StudentId = c.StudentId,
                                 TeacherId = c.TeacherId,
                                 Surname = c.Surname,
                                 Class = c.Class,
                                 Gender = c.Gender,
                                 District = c.District,
                                 City = c.City,
                                 Section = c.Section,
                                 Name = c.Name,
                                 Phone = c.Phone,
                                 IdentificationNumber=c.IdentificationNumber,

                             };
                return result.ToList();
            }
        }


    }
}
