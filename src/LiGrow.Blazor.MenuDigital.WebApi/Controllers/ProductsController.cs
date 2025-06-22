using LiGrow.Blazor.MenuDigital.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LiGrow.Blazor.MenuDigital.WebApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
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
   }
}
