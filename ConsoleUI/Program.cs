using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager(new EfStudentDal());
            var result = studentManager.GetStudentDetails();
            if (result.Success == true)
            {
                foreach (var student in result.Data)
                {
                    Console.WriteLine(student.StudentName + "/" + student.City + "/" + student.Phone + "/" + student.TeacherName );
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
