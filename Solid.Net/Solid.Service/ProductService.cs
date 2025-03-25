using Microsoft.EntityFrameworkCore;
using Solid.Data;
using Solid.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class ProductService
    {
        ProductRepository _repository;

        public ProductService()
        {
            _repository = new ProductRepository();
        }

        public List<Product> GetAll()
        {
            return _repository.Get();
        }
        public Product Get(int id)
        {
            return _repository.GetProductById(id);
        }

        public Product AddProduct(Product product)
        {
            // אם קיים המוצר לפי השם לטפל לוגיקה
            return _repository.Add(product);
        }
        public Product UpdateProduct(int id,Product product)
        {
            return _repository.Update(id,product);
        }
        public Product DeleteProduct(int id)
        {
           return _repository.Delete(id);
        }

    }
}
