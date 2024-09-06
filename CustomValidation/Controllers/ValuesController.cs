using CustomValidation.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        public ActionResult createProduct(Product product)
        {
            return Ok("As validações foram feitas com sucesso!");
        }

        [HttpPost("two")]
        public ActionResult createProductTwo(ProductTwo productTwo)
        {
            return Ok("As validações foram feitas com sucesso!");
        }
    }
}
