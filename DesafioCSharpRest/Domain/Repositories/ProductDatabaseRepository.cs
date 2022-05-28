using DesafioCSharpRest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioCSharpRest.Utils;
using Microsoft.EntityFrameworkCore;

namespace DesafioCSharpRest.Domain.Repositories
{
    internal class ProductDatabaseRepository : IRepository
    {
        private DesafioCSharpRestDBContext? context; 
        private DbSet<Product> products;

        public ProductDatabaseRepository()
        {
            this.context = new DesafioCSharpRestDBContext();
            this.products = this.context.Products;
        }
        public void delete(int id)
        {
            Product product =  this.findById(id);
            products.Remove(product);
            if (context != null)
                context.SaveChanges();
        }

        public List<Product> findAll()
        {
            return this.products.ToList();
        }

        public Product findById(Int32 id)
        {
            return this.products
                .Where(product => product.Id.Equals(id))
                .First();
        }

        public Product save(Product product)
        {
             product = this.products.Add(product).Entity;
            if (context != null)
                context.SaveChanges();
            return product;
        }

        public Product update(Product product)
        {
            product = this.products.Update(product).Entity;
            if(context!=null)
                context.SaveChanges();
            return product;
        }

        private static ProductDatabaseRepository? instance;
        public static ProductDatabaseRepository getInstance()
        {
            return instance ?? (instance = new ProductDatabaseRepository());
        }
    }
}
