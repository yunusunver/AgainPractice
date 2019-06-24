using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Entities.Concrete;
using FluentValidation;

namespace AgainPractice.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün ismi boş bırakılamaz.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Resim eklemeniz gerekmektedir.");
        }
    }
}
