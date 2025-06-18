namespace LiGrow.Blazor.MenuDigital.Web.Models
{
   public class MenuItem
   {
        public int id { get; set; }
        public int id_categoria { get; set; }
        public string? slug_menu { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public decimal preco { get; set; }
        public string? imagem { get; set; }
    }
}
