using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pokedexx.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        [HttpGet]
        public string GetPokemons()
        {
            return "string qualquer";
        }
    }
}
