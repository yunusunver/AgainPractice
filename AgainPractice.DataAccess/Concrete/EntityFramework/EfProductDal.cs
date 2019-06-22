using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Core.DataAccess.EntityFramework;
using AgainPractice.DataAccess.Abstract;
using AgainPractice.Entities.Concrete;

namespace AgainPractice.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,PracticeContext>,IProductDal
    {
    }
}
