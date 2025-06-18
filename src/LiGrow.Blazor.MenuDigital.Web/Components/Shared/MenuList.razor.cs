using LiGrow.Blazor.MenuDigital.Web.Models;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;

namespace LiGrow.Blazor.MenuDigital.Web.Components.Shared
{
   public partial class MenuList : ComponentBase
   {
      private List<CategoriaItem> _listaCategorias = new List<CategoriaItem>();
      private List<MenuItem> _listaMenus = new List<MenuItem>();

      protected override async Task OnInitializedAsync()
      {
         _listaCategorias = await WebApiCall.Categoria.ObterLista();
         _listaMenus = await WebApiCall.Menu.ObterLista();
      }
   }
}
