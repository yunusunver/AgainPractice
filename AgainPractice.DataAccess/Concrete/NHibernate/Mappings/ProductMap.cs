using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace AgainPractice.DataAccess.Concrete.NHibernate.Mappings
{
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Table(@"Product");
            LazyLoad();
            Id(x => x.Id).Column("Id");
            Map(x => x.CategoryId).Column("CategoryId");
            Map(x => x.Image).Column("Image");
            Map(x => x.CategoryName).Column("CategoryName");
        }
    }
}
