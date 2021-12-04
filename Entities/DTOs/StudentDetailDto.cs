using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class StudentDetailDto : IDto
    {
        public int StudentId { get; set; }
        public string TeacherName { get; set; }
        public string StudentName { get; set; }
        public string ParentName { get; set; }
        public string Surname { get; set; }
        public int IdentificationNumber { get; set; }
        public int Class { get; set; }
        public string Gender { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }
        public string Section { get; set; }
    }
}
