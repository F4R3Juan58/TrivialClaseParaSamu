using Syncfusion.Maui.Maps;
using Syncfusion.Maui.ProgressBar;
using TrivialGeografia.Modelos;

namespace TrivialGeografia
{
    public partial class MainPage : ContentPage
    {
        int aprobados = InfoContinenteAprobado.aprobados;
        public MainPage()
        {
            InitializeComponent();
        }


        private void OnShapeSelected(object sender, Syncfusion.Maui.Maps.ShapeSelectedEventArgs e)
        {
            if (e.IsSelected && e.DataItem is ModeloWorld selectedItem)
            {
                quest(selectedItem.Continent);
            }
        }

        private async void quest(string continente)
        {
            if (continente == "Europe") await Navigation.PushAsync(new Europa());
            if (continente == "Asia") await Navigation.PushAsync(new Asia());
            if (continente == "North America") await Navigation.PushAsync(new NorthAmerica());
            if (continente == "South America") await Navigation.PushAsync(new SouthAmerica());
            if (continente == "Australia") await Navigation.PushAsync(new Oceania());
            if (continente == "Africa") await Navigation.PushAsync(new Africa());
        }

        
        private void onReiniciar(object sender, EventArgs e)
        {
            InfoContinenteAprobado.AciertosLista.Clear();
            InfoContinenteAprobado.FallosLista.Clear();
        }
    }
}





