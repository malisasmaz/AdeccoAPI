using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokeApiNet;
using System.Net.Http;
using Newtonsoft.Json;
using AdeccoAPI.Services;

namespace AdeccoAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase {

        private readonly IPokemonService _service;

        public PokemonController(IPokemonService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<NamedApiResourceList<NamedApiResource>> GetAll() {

            //TODO 20 tane pokemonu çekeceğim

            return await _service.GetAll();
        }

        [HttpGet("{input}")]
        public async Task<Pokemon> GetByNameOrId(string input) {
            return await _service.GetByNameOrId(input);
        }
    }
}
