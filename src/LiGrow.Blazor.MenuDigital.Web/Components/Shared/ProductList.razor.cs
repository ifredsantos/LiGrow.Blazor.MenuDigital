using LiGrow.Blazor.MenuDigital.Web.Models;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;

namespace LiGrow.Blazor.MenuDigital.Web.Components.Shared
{
   public partial class ProductList : ComponentBase
   {
      private List<CategoryItem> _listaCategorias = new List<CategoryItem>();
      private List<ProductItem> _listaMenus = new List<ProductItem>();

      protected override async Task OnInitializedAsync()
      {
         _listaCategorias = await WebApiCall.Category.ObterLista();
         _listaMenus = await WebApiCall.Product.ObterLista();
      }
   }
}
