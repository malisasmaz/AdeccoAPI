using PokeApiNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdeccoAPI.Services {
    public interface IPokemonService {
        Task<NamedApiResourceList<NamedApiResource>> GetAll();
        Task<Pokemon> GetByNameOrId(string name);
    }
}
