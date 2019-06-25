using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Core.DataAccess;
using AgainPractice.Core.DataAccess.EntityFramework;
using AgainPractice.DataAccess.Abstract;
using AgainPractice.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace AgainPractice.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryDal>().To<EfCategoryDal>();

            Bind<IProductDal>().To<EfProductDal>();

            Bind<DbContext>().To<PracticeContext>();

        }
    }
}
