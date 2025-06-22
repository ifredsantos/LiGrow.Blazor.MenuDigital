using LiGrow.Blazor.MenuDigital.Web.Models;

namespace LiGrow.Blazor.MenuDigital.Web.Services.Interfaces
{
   public interface ICategoryService
   {
      Task<List<CategoryItem>> GetItemsAsync();
   }
}
