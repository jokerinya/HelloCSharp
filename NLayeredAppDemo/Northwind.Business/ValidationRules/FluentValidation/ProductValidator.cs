using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty().GreaterThan(0);
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty().GreaterThanOrEqualTo((short)0);

            // Custom rule
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Product name should start with A");

        }

        private bool StartWithA(string arg)
        {
            // if this retuns true, rule will pass
            return arg.StartsWith("A");
        }
    }
}
