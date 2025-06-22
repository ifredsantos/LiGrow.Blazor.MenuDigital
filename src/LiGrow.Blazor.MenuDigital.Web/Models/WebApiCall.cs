namespace LiGrow.Blazor.MenuDigital.Web.Models
{
   public partial class WebApiCall
   {
      public static class Category
      {
         public static async Task<List<CategoryItem>> ObterLista()
         {
            return await FakerData.Category.ObterLista();
         }
      }

      public static class Product
      {
         public static async Task<List<ProductItem>> ObterLista()
         {
            return await FakerData.Product.ObterLista();
         }
      }
   }
}
