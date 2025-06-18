namespace LiGrow.Blazor.MenuDigital.Web.Models
{
   public partial class WebApiCall
   {
      public static class Categoria
      {
         public static async Task<List<CategoriaItem>> ObterLista()
         {
            return await FakerData.Categoria.ObterLista();
         }
      }

      public static class Menu
      {
         public static async Task<List<MenuItem>> ObterLista()
         {
            return await FakerData.Menu.ObterLista();
         }
      }
   }
}
