using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Entities.Concrete;
using AutoMapper;

namespace AgainPractice.Business.Mappings.AutoMapper.Profiles
{
    public class BusinessProfile:Profile
    {
        public BusinessProfile()
        {
            CreateMap<Product, Product>();
        }
    }
}
