using Microsoft.AspNetCore.Mvc;

namespace Pedidos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Item 1", "Item 2" };
        }
    }
}