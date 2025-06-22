using LiGrow.Blazor.MenuDigital.Web.Models;
using LiGrow.Blazor.MenuDigital.Web.Services.Interfaces;

namespace LiGrow.Blazor.MenuDigital.Web.Services
{
   public class ProductService : IProductService
   {
      private readonly HttpClient _httpClient;

      public ProductService(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }

      public async Task<List<ProductItem>> GetItemsAsync()
      {
         return await _httpClient.GetFromJsonAsync<List<ProductItem>>("/api/products");
      }
   }
}
