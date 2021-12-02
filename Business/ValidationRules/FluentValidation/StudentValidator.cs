using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   public class StudentValidator: AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(p => p.City).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(2);

        }
    }
}
