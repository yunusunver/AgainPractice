using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Business.ValidationRules.FluentValidation;
using AgainPractice.Entities.Concrete;
using FluentValidation;
using Ninject.Modules;

namespace AgainPractice.Business.DependencyResolvers.Ninject
{
    public class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Category>>().To<CategoryValidator>();
            Bind<IValidator<Product>>().To<ProductValidator>();
        }
    }
}
