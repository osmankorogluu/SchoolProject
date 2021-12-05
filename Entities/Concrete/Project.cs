using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Project:IEntity
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int Class { get; set; }
        public DateTime GivenDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string GradeGiven { get; set; }
        public string Department { get; set; }
        public string Lesson { get; set; }
    }
}
