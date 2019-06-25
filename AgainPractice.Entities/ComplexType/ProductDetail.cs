using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Core.Entities;

namespace AgainPractice.Entities.ComplexType
{
    public class ProductDetail:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Image { get; set; }
    }
}
