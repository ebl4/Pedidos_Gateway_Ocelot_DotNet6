using Microsoft.AspNetCore.Mvc;

namespace Produtos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Produto 1", "Produto 2" };
        }
    }
}