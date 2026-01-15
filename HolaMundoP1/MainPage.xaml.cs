using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Threading.Tasks;

namespace HolaMundoP1
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
           string result=await DisplayPromptAsync("Nombre","Cual es su Nombre?");
            Toast.Make("Hola: "+result, ToastDuration.Short).Show();
        }
    }
}
