using Newtonsoft.Json;
using PokeApiNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdeccoAPI.Services {
    public class PokemonService : IPokemonService {

        private readonly HttpClient _client;
        private readonly Uri _baseUri = new Uri("https://pokeapi.co/api/v2/");

        //TODO: control here
        public PokemonService() {
            _client = new HttpClient { BaseAddress = _baseUri };
        }

        public async Task<NamedApiResourceList<NamedApiResource>> GetAll() {
            var response = _client.GetAsync("pokemon");
            var data = await response.Result.Content.ReadAsStringAsync();
            var myInstance = JsonConvert.DeserializeObject<NamedApiResourceList<NamedApiResource>>(data);

            return myInstance;
        }

        public async Task<Pokemon> GetByNameOrId(string name) {
            StringBuilder sb = new StringBuilder();
            sb.Append("pokemon/");
            sb.Append(name);
            string url = sb.ToString();
            var response = _client.GetAsync(url);
            var data = await response.Result.Content.ReadAsStringAsync();
            var myInstance = JsonConvert.DeserializeObject<Pokemon>(data);

            return myInstance;
        }
    }
}
