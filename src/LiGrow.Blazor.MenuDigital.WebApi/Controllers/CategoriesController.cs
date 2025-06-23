using LiGrow.Blazor.MenuDigital.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LiGrow.Blazor.MenuDigital.WebApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController, ApiKeyAuth]
   public class CategoriesController : ControllerBase
   {
      private readonly ILogger<CategoriesController> _logger;

      public CategoriesController(ILogger<CategoriesController> logger)
      {
         _logger = logger;
      }

      [HttpGet]
      public IEnumerable<Category> Get()
      {
         throw new Exception("Teste!");
         return FakerData.Category.ObterLista();
      }
   }
}
