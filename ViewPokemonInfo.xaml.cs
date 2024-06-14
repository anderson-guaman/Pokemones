
using Pokemones.Models;
using Pokemones.Services;

namespace Pokemones;

public partial class ViewPokemonInfo : ContentPage
{
	public ViewPokemonInfo(PokemonItem pokemon)
	{
        InitializeComponent();
		CargaPokemon(pokemon);
	}

    public async void CargaPokemon(PokemonItem pokemon)
	{
        PokemonServices pokemonServices = new PokemonServices();
        var pokemon_info = await pokemonServices.GetPokemonInfo(pokemon);
		string image = pokemon_info.sprites.Front_Default;
        PokemonImage.Source = image;


        var nombresHabilidades = pokemon_info.abilities
        .Select(a => a.ability.Name)
        .ToList();
        lstHabilidades.ItemsSource = nombresHabilidades;
    }
}