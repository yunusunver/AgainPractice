using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.DataAccess.Concrete.EntityFramework.Mappings;
using AgainPractice.Entities.Concrete;

namespace AgainPractice.DataAccess.Concrete.EntityFramework
{
    public class PracticeContext:DbContext
    {
        public PracticeContext()
        {
            Database.SetInitializer<PracticeContext>(null);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
