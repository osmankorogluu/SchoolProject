using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Teacher:IEntity
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Phone { get; set; }
        public string Branch { get; set; }
    }
}
