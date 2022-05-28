using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesafioCSharpRest.Domain.Models;

namespace DesafioCSharpRest.Utils
{
    internal class DesafioCSharpRestDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server=.\SQLServer;User Id=sa;Password=SQLServer;Database=DesafioCSharpRest;Trusted_Connection=True;");
        }
    }
}
