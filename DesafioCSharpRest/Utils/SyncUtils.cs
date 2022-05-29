using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using DesafioCSharpRest.Domain.Repositories;
using DesafioCSharpRest.Domain.Models;
using DesafioCSharpRest.EndPoint;
using DesafioCSharpRest.EndPoint.DTO;


namespace DesafioCSharpRest.Utils
{
    internal sealed class SyncUtils
    {
        private SyncUtils() { }

        private static System.Threading.Timer _timer;
        private static AutoResetEvent _event;
        public static void startSync()
        {

            if (_timer != null)
                _timer.Dispose();

            _event = new AutoResetEvent(false);
            _timer = new System.Threading.Timer(performSync, _event, 0, 30 * 60 * 1000);
        }

        private static void performSync(object? state)
        {
            var endpoint = ProductEndPointRepository.getInstance();
            var dbset = ProductDatabaseRepository.getInstance();
            List<Product> productsToSave = dbset.findByIsSyncSave();
            List<Product> productsToUpdate = dbset.findByIsSyncUpdate();

            int total = productsToSave.Count + productsToUpdate.Count;

            if (productsToSave.Count > 0)
            {
                foreach (Product product in productsToSave)
                {
                    Product savedProduct = endpoint.save(product).Result;
                    if (savedProduct != null)
                    {
                        product.ServerId = savedProduct.ServerId;
                        product.Inactive = savedProduct.Inactive;
                        product.ComponentType = savedProduct.ComponentType;
                        product.IsSyncSave = true;
                        product.IsSyncUpdate = true;
                        dbset.update(product);
                    }
                }
            }



            if (productsToUpdate.Count > 0)
            {
                foreach (Product product in productsToUpdate)
                {
                    Product updatedProduct = endpoint.update(product).Result;
                    if (updatedProduct != null)
                    {
                        product.ServerId = updatedProduct.ServerId;
                        product.Inactive = updatedProduct.Inactive;
                        product.ComponentType = updatedProduct.ComponentType;
                        product.IsSyncUpdate = true;
                        dbset.update(product);
                    }
                }
            }
            

        }

        public static void stopSync()
        {
            if (_timer != null)
            {
                _timer.Dispose();
            }
        }
    }
}
