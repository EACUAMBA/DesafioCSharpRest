using DesafioCSharpRest.Domain.Models;
using DesafioCSharpRest.Domain.Repositories;
using DesafioCSharpRest.Utils;
using DesafioCSharpRest.EndPoint;
using Quickwire.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCSharpRest.Domain.Services
{
    internal class ProductService
    {
        public IRepository repository = ProductDatabaseRepository.getInstance();
        private static ProductService instance;
        public static ProductService getInsance()
        {
            return instance ?? (instance = new ProductService());
        }

        public Product saveProduct(Product product)
        {
            // 1 - Salvar no banco de dados
            // 2 - Criar uma Thread nova e tentar salvar/actualizar na API Rest enquanto não tiver resposta 200 OK, quando tiver a resposta 200 OK actualizar o estado do producto na base de dados para sincronizado.
            // 3 - Ao iniciar a aplicação verificar se tem productos por sincronozar, caso tenha executa o ponto 2.
            product.IsSyncUpdate = true;
            product.IsSyncSave = false;
            product = this.repository.save(product);
            SyncUtils.stopSync();
            SyncUtils.startSync();
            return product;
        }

        public Product updateProduct(Product product)
        {
            // 1 - Salvar no banco de dados
            // 2 - Criar uma Thread nova e tentar salvar/actualizar na API Rest enquanto não tiver resposta 200 OK, quando tiver a resposta 200 OK actualizar o estado do producto na base de dados para sincronizado.
            // 3 - Ao iniciar a aplicação verificar se tem productos por sincronozar, caso tenha executa o ponto 2.
            product.IsSyncUpdate = false;
            product.IsSyncSave = true;
            product = this.repository.update(product);
            SyncUtils.stopSync();
            SyncUtils.startSync();
            return product;
        }
    }
}
