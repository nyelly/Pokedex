using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokedexx.Dominio;
using System.Collections.Generic;

namespace Pokedexx.Api.Controllers
{
    [ApiController]
    [Route("api/pokedex")]
    public class PokemonController : ControllerBase
    {
        private readonly Pokedex _pokedex;

        public PokemonController(Pokedex pokedex)
        {
            _pokedex = pokedex;
        }

        private static Pokedex pokedex = new Pokedex();

        [HttpPost("adicionarPokemon")]
        public ActionResult Add_Pokemon([FromBody] Pokemon pokemon)
        {
            _pokedex.AdicionarPokemon(pokemon);
            return Ok(new { mensagem = $" {pokemon.Nome} foi adicionado!!" });
        }

        [HttpGet("Listar_Pokemon")]
        public ActionResult GetAll()
        {
            return Ok(_pokedex.GetAll());
        }

        [HttpGet("Buscar/Id/{id}")]
        public IActionResult GetById(int id)
        {
            var pokemon = _pokedex.GetById(id);
            if (pokemon == null)
                return NotFound(new { mensagem = "Pokémon não encontrado" });

            return Ok(pokemon);
        }

        [HttpGet("buscar/nome/{nome}")]
        public IActionResult BuscarPokemon(string nome)
        {
            var pokemon = _pokedex.BuscarPokemon(nome);
            if (pokemon == null)
                return NotFound(new { mensagem = "Pokémon não encontrado." });

            return Ok(pokemon);
        }

    }
}