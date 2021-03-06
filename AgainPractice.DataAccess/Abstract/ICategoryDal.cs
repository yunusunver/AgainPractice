﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainPractice.Core.DataAccess;
using AgainPractice.Entities.ComplexType;
using AgainPractice.Entities.Concrete;

namespace AgainPractice.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        List<ProductDetail> GetListProductDetail();

    }
}
