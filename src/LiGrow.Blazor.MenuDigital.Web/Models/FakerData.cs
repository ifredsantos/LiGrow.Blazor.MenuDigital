namespace LiGrow.Blazor.MenuDigital.Web.Models
{
   public static class FakerData
   {
      public class Categoria
      {
         public static async Task<List<CategoriaItem>> ObterLista()
         {
            //await Task.Delay(1000); 

            return new List<CategoriaItem>
            {
               new CategoriaItem
               {
                  id = 1,
                  nome = "Petiscos"
               },
               new CategoriaItem
               {
                  id = 2,
                  nome = "Especiais",
                  descricao = "Para gostos mais requintados"
               },
            };
         }
      }
      public class Menu
      {
         public static async Task<List<MenuItem>> ObterLista()
         {
            //await Task.Delay(1000);

            return new List<MenuItem>
            {
               new MenuItem
               {
                  id = 1,
                  id_categoria = 1,
                  slug_menu = "/produto/tabua-mediteranea",
                  nome = "Tábua Mediterrânea",
                  descricao = "Pão, Queijo da Serra e presunto curado 12 meses",
                  preco = 26,
                  imagem = "/assets/images/menu/Tinela-27.jpg"
               },
               new MenuItem
               {
                  id = 2,
                  id_categoria = 1,
                  slug_menu = "/produto/tabua-mediteranea",
                  nome = "Tábua Mediterrânea",
                  descricao = "Pão, Queijo da Serra e presunto curado 12 meses",
                  preco = 26,
                  imagem = "/assets/images/menu/Tinela-26.jpg"
               },
               new MenuItem
               {
                  id = 3,
                  id_categoria = 1,
                  slug_menu = "/produto/tabua-mediteranea",
                  nome = "Tábua Mediterrânea",
                  descricao = "Pão, Queijo da Serra e presunto curado 12 meses",
                  preco = 26,
                  imagem = "/assets/images/menu/Tinela-27.jpg"
               },
               new MenuItem
               {
                  id = 4,
                  id_categoria = 2,
                  slug_menu = "/produto/cabrito-assado",
                  nome = "Cabrito assado",
                  descricao = "Arroz de Miúdos, Batata Assada e Grelos",
                  preco = 18.40m,
                  imagem = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
               new MenuItem
               {
                  id = 5,
                  id_categoria = 2,
                  slug_menu = "/produto/cabrito-assado",
                  nome = "Cabrito assado",
                  descricao = "Arroz de Miúdos, Batata Assada e Grelos",
                  preco = 18.40m,
                  imagem = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
               new MenuItem
               {
                  id = 6,
                  id_categoria = 2,
                  slug_menu = "/produto/cabrito-assado",
                  nome = "Cabrito assado",
                  descricao = "Arroz de Miúdos, Batata Assada e Grelos",
                  preco = 18.40m,
                  imagem = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
               new MenuItem
               {
                  id = 7,
                  id_categoria = 2,
                  slug_menu = "/produto/cabrito-assado",
                  nome = "Cabrito assado",
                  descricao = "Arroz de Miúdos, Batata Assada e Grelos",
                  preco = 18.40m,
                  imagem = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
               new MenuItem
               {
                  id = 8,
                  id_categoria = 2,
                  slug_menu = "/produto/cabrito-assado",
                  nome = "Cabrito assado",
                  descricao = "Arroz de Miúdos, Batata Assada e Grelos",
                  preco = 18.40m,
                  imagem = "https://placehold.co/150x150/000000/FFFFFF?text=Foto+de+cabrito"
               },
            };
         }
      }
   }
}
