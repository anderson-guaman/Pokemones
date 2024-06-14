using Pokemones.Models;
using Pokemones.Services;

namespace Pokemones
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            LoadData();
        }

        public async void LoadData()
        {
            PokemonServices pokemonServices = new PokemonServices();
            var list_Pokemons = await pokemonServices.GetPokemonList();

            // daba error pero era por que el metodo anterior es asyn entonces debe ir con await
            lstPokemons.ItemsSource = list_Pokemons;
        }
        public async void ViewPokemonInfo(object sender, SelectedItemChangedEventArgs e)
        {
            PokemonItem pokemon = (PokemonItem)e.SelectedItem;
            //string url_pokemon = pokemon.URL;
            await Navigation.PushAsync(new ViewPokemonInfo(pokemon));
        }

    }

}
