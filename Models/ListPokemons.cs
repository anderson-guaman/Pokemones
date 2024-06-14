using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemones.Models
{
    internal class ListPokemons
    {
        public int Count { get; set; }
        public List<PokemonItem> Results { get; set; }
    }
}
