using DesafioCSharpRest.Domain.Models;
using DesafioCSharpRest.EndPoint.DTO;
using DesafioCSharpRest.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net;

namespace DesafioCSharpRest.EndPoint
{
    internal class ProductEndPointRepository
    {
        private static ProductEndPointRepository? instance;
        public static ProductEndPointRepository getInstance()
        {
            return instance ?? (instance = new ProductEndPointRepository());
        }
        private HttpClient _httpClient;

        public ProductEndPointRepository()
        {
            this._httpClient = new HttpClient();
            Uri uri = new Uri("https://test-reqwest-application.herokuapp.com");
            this._httpClient.BaseAddress = uri;
            this._httpClient.DefaultRequestHeaders.Clear();
            this._httpClient.DefaultRequestHeaders.Add("APPLICATION-ID", Environment.GetEnvironmentVariable("APPLICATION-ID"));
            this._httpClient.DefaultRequestHeaders.Add("TENANT-ID", Environment.GetEnvironmentVariable("TENANT-ID"));
            this._httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Boolean> delete(int id)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "/products/" + id);
            httpRequestMessage.Headers.Add("Accept", "application/json");
            HttpResponseMessage httpResponseMessage = await this._httpClient.SendAsync(httpRequestMessage);
            return httpResponseMessage.StatusCode.Equals(200);
        }

        public async Task<List<Product>> findAll()
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "/products");
            httpRequestMessage.Headers.Add("Accept", "application/json");
            HttpResponseMessage httpResponseMessage = await this._httpClient.SendAsync(httpRequestMessage);
            dynamic value = await httpResponseMessage.Content.ReadAsStringAsync();
            if (value == null) return null;
            return ((List<ProductDTO>)JsonConvert.DeserializeObject<ProductDTO>(value.elements)).Select(produtoDTO => produtoDTO.getProduct()).ToList();
        }

        public async Task<Product> findById(int id)
        { 
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "/products/" + id);
            httpRequestMessage.Headers.Add("Accept", "application/json");
            HttpResponseMessage httpResponseMessage = await this._httpClient.SendAsync(httpRequestMessage);
            var value = await httpResponseMessage.Content.ReadAsStringAsync();
            if (httpResponseMessage.StatusCode.Equals(HttpStatusCode.OK) && value == null) return null;
            return ((ProductDTO)JsonConvert.DeserializeObject<ProductDTO>(value)).getProduct();
        }

        public async Task<Product> save(Product product)
        {
            
            ProductDTO productDTO = new ProductDTO(product);
            var value = JsonConvert.SerializeObject(productDTO);
            HttpContent httpContent = new StringContent(value);
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, "/products");
            httpRequestMessage.Content = new StringContent(value, Encoding.UTF8, "application/json");
            httpRequestMessage.Headers.Add("Accept", "application/json");
            HttpResponseMessage httpResponseMessage = await this._httpClient.SendAsync(httpRequestMessage);
            String productJson = httpResponseMessage.Content.ReadAsStringAsync().Result;

            if (!httpResponseMessage.StatusCode.Equals(HttpStatusCode.Created) || productJson == null) return null;

            product = JsonConvert
                .DeserializeObject<ProductDTO>(productJson)
                .getProduct();

            return product;
        }

        public async Task<Product> update(Product product)
        {
            ProductDTO productDTO = new ProductDTO(product);
            var value = JsonConvert.SerializeObject(productDTO);
            HttpContent httpContent = new StringContent(value);
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, "/products/" + product.ServerId);
            httpRequestMessage.Content = new StringContent(value, Encoding.UTF8, "application/json");
            httpRequestMessage.Headers.Add("Accept", "application/json");
            HttpResponseMessage httpResponseMessage = await this._httpClient.SendAsync(httpRequestMessage);
            String productJson = httpResponseMessage.Content.ReadAsStringAsync().Result;

            if (!httpResponseMessage.StatusCode.Equals(HttpStatusCode.OK) || productJson == null) return null;

            product = JsonConvert
                .DeserializeObject<ProductDTO>(productJson)
                .getProduct();

            return product;
        }
    }
    
}
