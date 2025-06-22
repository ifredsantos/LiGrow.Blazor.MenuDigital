using LiGrow.Blazor.MenuDigital.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LiGrow.Blazor.MenuDigital.WebApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class CategoryController : ControllerBase
   {
      private readonly ILogger<CategoryController> _logger;

      public CategoryController(ILogger<CategoryController> logger)
      {
         _logger = logger;
      }

      [HttpGet]
      public IEnumerable<Category> Get()
      {
         return FakerData.Category.ObterLista();
      }
   }
}
