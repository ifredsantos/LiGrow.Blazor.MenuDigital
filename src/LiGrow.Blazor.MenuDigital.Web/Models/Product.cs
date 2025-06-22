namespace LiGrow.Blazor.MenuDigital.Web.Models
{
   public class ProductItem
   {
        public int id { get; set; }
        public int category_id { get; set; }
        public string? slug { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public decimal price { get; set; }
        public string? image { get; set; }
    }
}
