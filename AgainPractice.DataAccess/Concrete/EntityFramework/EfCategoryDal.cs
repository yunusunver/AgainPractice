using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Core.DataAccess.EntityFramework;
using AgainPractice.DataAccess.Abstract;
using AgainPractice.Entities.ComplexType;
using AgainPractice.Entities.Concrete;

namespace AgainPractice.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal: EfEntityRepositoryBase<Category,PracticeContext>,ICategoryDal
    {
        public List<ProductDetail> GetListProductDetail()
        {
            
                using (var context = new PracticeContext())
                {
                    var result = (from c in context.Categories
                        join p in context.Products on c.Id equals p.CategoryId
                        select new ProductDetail
                        {
                            CategoryId = c.Id,
                            CategoryName = c.Name,
                            Image = p.Image,
                            ProductId = p.Id
                        });
                    return result.ToList();
                }
            
        }
    }
}
