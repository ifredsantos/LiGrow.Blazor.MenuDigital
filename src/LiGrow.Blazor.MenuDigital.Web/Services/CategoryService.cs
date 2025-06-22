using LiGrow.Blazor.MenuDigital.Web.Models;
using LiGrow.Blazor.MenuDigital.Web.Services.Interfaces;

namespace LiGrow.Blazor.MenuDigital.Web.Services
{
   public class CategoryService : ICategoryService
   {
      private readonly HttpClient _httpClient;

      public CategoryService(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }

      public async Task<List<CategoryItem>> GetItemsAsync()
      {
         return await _httpClient.GetFromJsonAsync<List<CategoryItem>>("/api/categories");
      }
   }
}
