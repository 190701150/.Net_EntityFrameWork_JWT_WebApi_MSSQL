using System;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
        public EfCategoryDal()
        {
        }

        
    }
}
