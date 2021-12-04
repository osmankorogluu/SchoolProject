using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Parent : IEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Proximity { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string IdentificationNumber { get; set; }
        public string Income { get; set; }
    }
}
