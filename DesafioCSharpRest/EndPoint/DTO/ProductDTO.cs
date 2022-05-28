using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioCSharpRest.Domain.Models;
using Newtonsoft.Json;

namespace DesafioCSharpRest.EndPoint.DTO
{
    internal class ProductDTO
    {
        [JsonProperty("id")]
        public Int32 Id { get; set; }
        [JsonProperty("identifier")]
        public String Identifier { get; set; }
        [JsonProperty("description")]
        public String Description { get; set; }
        [JsonProperty("descriptionEN")]
        public String DescriptionEN { get; set; }
        [JsonProperty("price")]
        public Decimal Price { get; set; }
        [JsonProperty("unit")]
        public String Unit { get; set; }
        [JsonProperty("availableSTK")]
        public Double AvailableSTK { get; set; }
        [JsonProperty("vat")]
        public Double VAT { get; set; }
        [JsonProperty("inactive")]
        public Boolean Inactive { get; set; }
        [JsonProperty("componentType")]
        public Int32 ComponentType { get; set; }
        [JsonIgnore]
        public Int32 ServerId { get; set; }

        public ProductDTO(Product product)
        {
            this.ServerId = product.ServerId;
            this.Identifier = product.Identifier;
            this.Description = product.Description;
            this.DescriptionEN = product.DescriptionEN;
            this.Price = product.Price;
            this.Unit = product.Unit;
            this.AvailableSTK = product.AvailableSTK;
            this.VAT = product.VAT;
        }

        public Product getProduct()
        {
            Product product = new Product();
            product.Identifier = this.Identifier;
            product.Description = this.Description;
            product.DescriptionEN = this.DescriptionEN;
            product.Price = this.Price;
            product.Unit = this.Unit;
            product.AvailableSTK = this.AvailableSTK;
            product.VAT = this.VAT;
            product.ServerId = this.Id;
            return product;
        }
    }
}
