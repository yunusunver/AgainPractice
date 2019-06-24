using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Business.Abstract;
using AgainPractice.DataAccess.Abstract;
using AgainPractice.Entities.Concrete;

namespace AgainPractice.Business.Concrete.Managers
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(x=>x.Id==id);
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}
