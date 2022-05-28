using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCSharpRest.Domain.Models
{
    internal class Product
    {
        public Int32 Id { get; set; }
        public String Identifier { get; set; }
        public String Description { get; set; }
        public String DescriptionEN { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Price { get; set; }
        public String Unit { get; set; }
        public Double AvailableSTK { get; set; }
        public Double VAT { get; set; }

        public Boolean IsSyncUpdate { get; set; }

        public Boolean IsSyncSave { get; set; }
    }
}
