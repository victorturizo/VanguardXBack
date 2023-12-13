using ClientsAPI.Business.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClients _clients;

        public ClientsController(IClients clients)
        {
         _clients = clients;
        }

        [HttpGet]
        public IActionResult GetClients()
        {
            return Ok(_clients.GetClientsAsync());
        }
    }
}
