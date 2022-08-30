﻿using System;
using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager: ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        

        public IDataResult<List<Category>> GetAll()
        {
            // yetkilendirme auth vb..
            // IS KODLARI
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        // Select * from Categories where CategoryId = 3;

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}

