using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Entities.Concrete;

namespace AgainPractice.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category Get(int id);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}
