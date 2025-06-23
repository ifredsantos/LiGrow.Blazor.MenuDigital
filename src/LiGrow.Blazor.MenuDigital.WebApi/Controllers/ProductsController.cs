using LiGrow.Blazor.MenuDigital.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LiGrow.Blazor.MenuDigital.WebApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController, ApiKeyAuth]
   public class ProductsController : ControllerBase
   {
      private readonly ILogger<ProductsController> _logger;

      public ProductsController(ILogger<ProductsController> logger)
      {
         _logger = logger;
      }

      [HttpGet]
      public IEnumerable<Product> Get()
      {
         return FakerData.Product.ObterLista();
      }

      [HttpGet("{slug}")]
      public ActionResult<Product> GetBySlug(string slug)
      {
         var product = FakerData.Product.ObterLista().FindAll(x => x.slug.ToLower() == slug.ToLower());

         if (product == null)
         {
            return NotFound();
         }

         return Ok(product);
      }
   }
}
