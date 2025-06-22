using LiGrow.Blazor.MenuDigital.Web.Models;
using LiGrow.Blazor.MenuDigital.Web.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;

namespace LiGrow.Blazor.MenuDigital.Web.Components.Shared
{
   public partial class ProductList : ComponentBase
   {
      [Inject]
      public IProductService ProductService { get; set; }

      private List<ProductItem> productsList = new List<ProductItem>();

      protected override async Task OnInitializedAsync()
      {
         productsList = await ProductService.GetItemsAsync();
      }
   }
}
