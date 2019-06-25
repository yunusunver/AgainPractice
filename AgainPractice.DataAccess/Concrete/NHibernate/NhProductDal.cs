using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Core.DataAccess.NHibernate;
using AgainPractice.DataAccess.Abstract;
using AgainPractice.Entities.Concrete;

namespace AgainPractice.DataAccess.Concrete.NHibernate
{
    public class NhProductDal:NhEntityRepositoryBase<Product>,IProductDal
    {
        public NhProductDal(NHibernateHelper hibernateHelper) : base(hibernateHelper)
        {
        }
    }
}
