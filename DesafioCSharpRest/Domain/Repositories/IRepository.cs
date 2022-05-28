using DesafioCSharpRest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCSharpRest.Domain.Repositories
{
    internal interface IRepository
    {
        Product save(Product product);
        void delete(Int32 id);
        Product update(Product product);
        Product findById(Int32 id);
        List<Product> findAll();

    }
}
