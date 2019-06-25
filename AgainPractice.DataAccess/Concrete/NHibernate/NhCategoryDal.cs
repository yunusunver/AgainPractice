using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Core.DataAccess.NHibernate;
using AgainPractice.DataAccess.Abstract;
using AgainPractice.DataAccess.Concrete.NHibernate.Helpers;
using AgainPractice.Entities.ComplexType;
using AgainPractice.Entities.Concrete;

namespace AgainPractice.DataAccess.Concrete.NHibernate
{
    public class NhCategoryDal:NhEntityRepositoryBase<Category>,ICategoryDal
    {
        private SqlServerHelper _sqlServerHelper;

        public NhCategoryDal(SqlServerHelper sqlServerHelper) : base(sqlServerHelper)
        {
            _sqlServerHelper = sqlServerHelper;
        }


        public NhCategoryDal(NHibernateHelper nHibernateHelper):base(nHibernateHelper)
        {
            
        }

        public List<ProductDetail> GetListProductDetail()
        {
            using (var session = _sqlServerHelper.OpenSession())
            {
                var result = (from c in session.Query<Category>()
                    join p in session.Query<Product>() on c.Id equals p.CategoryId
                    select new ProductDetail
                    {
                        CategoryId = c.Id,
                        Image = p.Image,
                        ProductId = p.Id,
                        CategoryName = c.Name
                    }).ToList();

                return result;
            }
        }
    }
}
