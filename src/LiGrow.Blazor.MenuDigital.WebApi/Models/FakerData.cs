namespace LiGrow.Blazor.MenuDigital.WebApi.Models
{
   public static class FakerData
   {
      public class Category
      {
         public static List<Models.Category> ObterLista()
         {
            return new List<Models.Category>
            {
               new Models.Category
               {
                  id = 1,
                  name = "Petiscos"
               },
               new Models.Category
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
         public static List<Models.Product> ObterLista()
         {
            //await Task.Delay(1000);

            return new List<Models.Product>
            {
               new Models.Product
               {
                  id = 1,
                  category_id = 1,
                  slug = "/produto/tabua-mediteranea",
                  name = "Tábua Mediterrânea",
                  description = "Pão, Queijo da Serra e presunto curado 12 meses",
                  price = 26,
                  image = "/assets/images/menu/Tinela-27.jpg"
               },
               new Models.Product
               {
                  id = 2,
                  category_id = 1,
                  slug = "/produto/tabua-mediteranea",
                  name = "Tábua Mediterrânea",
                  description = "Pão, Queijo da Serra e presunto curado 12 meses",
                  price = 26,
                  image = "/assets/images/menu/Tinela-26.jpg"
               },
               new Models.Product
               {
                  id = 3,
                  category_id = 1,
                  slug = "/produto/tabua-mediteranea",
                  name = "Tábua Mediterrânea",
                  description = "Pão, Queijo da Serra e presunto curado 12 meses",
                  price = 26,
                  image = "/assets/images/menu/Tinela-27.jpg"
               },
               new Models.Product
               {
                  id = 4,
                  category_id = 2,
                  slug = "/produto/cabrito-assado",
                  name = "Cabrito assado",
                  description = "Arroz de Miúdos, Batata Assada e Grelos",
                  price = 18.40m,
                  image = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
               new Models.Product
               {
                  id = 5,
                  category_id = 2,
                  slug = "/produto/cabrito-assado",
                  name = "Cabrito assado",
                  description = "Arroz de Miúdos, Batata Assada e Grelos",
                  price = 18.40m,
                  image = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
               new Models.Product
               {
                  id = 6,
                  category_id = 2,
                  slug = "/produto/cabrito-assado",
                  name = "Cabrito assado",
                  description = "Arroz de Miúdos, Batata Assada e Grelos",
                  price = 18.40m,
                  image = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
               new Models.Product
               {
                  id = 7,
                  category_id = 2,
                  slug = "/produto/cabrito-assado",
                  name = "Cabrito assado",
                  description = "Arroz de Miúdos, Batata Assada e Grelos",
                  price = 18.40m,
                  image = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
               new Models.Product
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
