using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace AgainPractice.DataAccess.Concrete.NHibernate.Mappings
{
    public class CategoryMap:ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Category");
            LazyLoad();
            Id(x => x.Id).Column("Id");

            Map(x => x.Name).Column("Name");
        }
    }
}
