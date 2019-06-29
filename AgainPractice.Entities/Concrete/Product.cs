using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Core.Entities;

namespace AgainPractice.Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
