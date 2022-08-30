﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal:IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            // Oracle, sql server, postgres, mongodb
            _products = new List<Product> {
                new Product{ProductId = 1, CategoryId=1, ProductName="bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId = 2, CategoryId=2, ProductName="kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId = 3, CategoryId=3, ProductName="telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId = 4, CategoryId=4, ProductName="klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId = 5, CategoryId=5, ProductName="fare", UnitPrice=85, UnitsInStock=1}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // bu calismaz----->  _products.Remove(product);

            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            // gonderdigim urun id'sine sahip olan listedeki urunu bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> fiter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> fiter = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}

