using FluentValidation;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Utilities
{
    // We will need this much, so static will be a better choice
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            // FluentValidation has removed Non-Generic validate overload for security with 9.0 update.
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
