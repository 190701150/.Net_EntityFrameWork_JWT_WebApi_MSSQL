using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        // ciplak class kalmasin
        public Category()
        {
        }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

    }
}
