namespace LiGrow.Blazor.MenuDigital.Web.Models
{
   public static class FakerData
   {
      public class Category
      {
         public static async Task<List<CategoryItem>> ObterLista()
         {
            //await Task.Delay(1000); 

            return new List<CategoryItem>
            {
               new CategoryItem
               {
                  id = 1,
                  name = "Petiscos"
               },
               new CategoryItem
               {
                  id = 2,
                  name = "Especiais",
                  description = "Para gostos mais requintados"
               },
            };
         }
      }
      public class Product
      {
         public static async Task<List<ProductItem>> ObterLista()
         {
            //await Task.Delay(1000);

            return new List<ProductItem>
            {
               new ProductItem
               {
                  id = 1,
                  category_id = 1,
                  slug = "/produto/tabua-mediteranea",
                  name = "Tábua Mediterrânea",
                  description = "Pão, Queijo da Serra e presunto curado 12 meses",
                  price = 26,
                  image = "/assets/images/menu/Tinela-27.jpg"
               },
               new ProductItem
               {
                  id = 2,
                  category_id = 1,
                  slug = "/produto/tabua-mediteranea",
                  name = "Tábua Mediterrânea",
                  description = "Pão, Queijo da Serra e presunto curado 12 meses",
                  price = 26,
                  image = "/assets/images/menu/Tinela-26.jpg"
               },
               new ProductItem
               {
                  id = 3,
                  category_id = 1,
                  slug = "/produto/tabua-mediteranea",
                  name = "Tábua Mediterrânea",
                  description = "Pão, Queijo da Serra e presunto curado 12 meses",
                  price = 26,
                  image = "/assets/images/menu/Tinela-27.jpg"
               },
               new ProductItem
               {
                  id = 4,
                  category_id = 2,
                  slug = "/produto/cabrito-assado",
                  name = "Cabrito assado",
                  description = "Arroz de Miúdos, Batata Assada e Grelos",
                  price = 18.40m,
                  image = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
               new ProductItem
               {
                  id = 5,
                  category_id = 2,
                  slug = "/produto/cabrito-assado",
                  name = "Cabrito assado",
                  description = "Arroz de Miúdos, Batata Assada e Grelos",
                  price = 18.40m,
                  image = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
               new ProductItem
               {
                  id = 6,
                  category_id = 2,
                  slug = "/produto/cabrito-assado",
                  name = "Cabrito assado",
                  description = "Arroz de Miúdos, Batata Assada e Grelos",
                  price = 18.40m,
                  image = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
               new ProductItem
               {
                  id = 7,
                  category_id = 2,
                  slug = "/produto/cabrito-assado",
                  name = "Cabrito assado",
                  description = "Arroz de Miúdos, Batata Assada e Grelos",
                  price = 18.40m,
                  image = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
               new ProductItem
               {
                  id = 8,
                  category_id = 2,
                  slug = "/produto/cabrito-assado",
                  name = "Cabrito assado",
                  description = "Arroz de Miúdos, Batata Assada e Grelos",
                  price = 18.40m,
                  image = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
            };
         }
      }
   }
}
