using System.Net.WebSockets;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object? sender, EventArgs e)
        {
            bool respuesta = await DisplayAlert("Pregunta", "Desea Continuar?", "Si", "No");
            Console.WriteLine(respuesta);
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string[] frutas = {"Manzana","Pera", "Naranja", "Plátano"};
            var data= await DisplayActionSheet("Seleccione una fruta", "Cancelar", null, frutas);
            Console.WriteLine(frutas);
        }

    }
}
