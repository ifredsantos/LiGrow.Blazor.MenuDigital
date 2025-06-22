using LiGrow.Blazor.MenuDigital.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LiGrow.Blazor.MenuDigital.WebApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class ProductController : ControllerBase
   {
      private readonly ILogger<ProductController> _logger;

      public ProductController(ILogger<ProductController> logger)
      {
         _logger = logger;
      }

      [HttpGet]
      public IEnumerable<Product> Get()
      {
         return FakerData.Product.ObterLista();
      }
   }
}
