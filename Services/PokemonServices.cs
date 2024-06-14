using Newtonsoft.Json;
using Pokemones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;
namespace Pokemones.Services
{
    internal class PokemonServices
    {
        public async Task<List<PokemonItem>> GetPokemonList()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=20&offset=20";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            ListPokemons listPokemons =JsonConvert.DeserializeObject<ListPokemons>(json);
            Debug.WriteLine("SII");
            Debug.WriteLine(json);
            return listPokemons.Results;
        }
        public async Task<PokemonInfo> GetPokemonInfo(PokemonItem pokemon)
        {
            string url = pokemon.URL;
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            PokemonInfo pokemon_info = JsonConvert.DeserializeObject<PokemonInfo>(json);
            Debug.WriteLine("SII");
            Debug.WriteLine(json);
            return pokemon_info;
        }

    }
}
