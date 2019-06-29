using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Entities.Concrete;

namespace AgainPractice.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap:EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Product", @"dto");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.Image).HasColumnName("Image");
        }
    }
}
