using LiGrow.Blazor.MenuDigital.Web.Models;

namespace LiGrow.Blazor.MenuDigital.Web.Services.Interfaces
{
   public interface IProductService
   {
      Task<List<ProductItem>> GetItemsAsync();
   }
}
