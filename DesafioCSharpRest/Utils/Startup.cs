using DesafioCSharpRest.Domain.Repositories;
using DesafioCSharpRest.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCSharpRest.Utils
{
    internal class Startup
    {
        public void ConfigureServices (IServiceCollection serviceCollection)
        {
            //serviceCollection.AddTransient<IRepository, ProductDatabaseRepository>();
            //serviceCollection.AddSingleton<ProductService>();
        }
    }
}
