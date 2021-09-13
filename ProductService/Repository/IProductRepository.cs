using ProductService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Repository
{
    interface IProductRepository
    {
        void DeleteProduct(int productId);
        Product GetProductByID(int productId);
        IEnumerable<Product> GetProducts();
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
    }
}
