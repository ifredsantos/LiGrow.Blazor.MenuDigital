using LiGrow.Blazor.MenuDigital.Web.Models;

namespace LiGrow.Blazor.MenuDigital.Web.Services
{
   public class AppState
   {
      public List<CategoryItem>? Categories { get; private set; }
      public bool IsCategoriesLoaded => Categories?.Any() == true;
      public string? CategoriesError { get; set; }

      public void SetCategories(List<CategoryItem> categories)
      {
         Categories = categories;
      }
   }
}
