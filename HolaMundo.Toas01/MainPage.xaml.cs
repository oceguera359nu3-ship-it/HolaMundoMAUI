


using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace HolaMundo.Toas01
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            Toast.Make("Hola desde Toast en MAUI", ToastDuration.Short).Show();
        }
    }
}
