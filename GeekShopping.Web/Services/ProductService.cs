﻿using GeekShopping.Web.Models;
using GeekShopping.Web.Models.Utils;
using GeekShopping.Web.Services.IServices;

namespace GeekShopping.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;

        public ProductService(HttpClient client)
        {
            _client = client;
        }

        public const string BasePath = "api/v1/product";
        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<ProductModel>>();
        }
        public async Task<ProductModel> FindById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ProductModel>();
        }
        public async Task<ProductModel> UpdateProduct(ProductModel model)
        {
            var response = await _client.PuttAsJson(BasePath, model);
            if (response.IsSuccessStatusCode) return await response.ReadContentAs<ProductModel>();
            else throw new Exception("Something went wrong when calling API");
        }
        public async Task<ProductModel> CreateProduct(ProductModel model)
        {
            var response = await _client.PostAsJson(BasePath, model);
            if (response.IsSuccessStatusCode) return await response.ReadContentAs<ProductModel>();
            else throw new Exception("Something went wrong when calling API");
        }

        public async Task<bool> DeleteProduct(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode) return await response.ReadContentAs<bool>();
            else throw new Exception("Something went wrong when calling API");
        }
    }
}