using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Suma2Numero
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                decimal numero1, numero2;
                if (Decimal.TryParse(Entrynum1.Text, out numero1) && Decimal.TryParse(Entrynum2.Text, out numero2))
                {
                    decimal suma = numero1 + numero2;
                    LabelResultado.Text = "La suma es: " + suma.ToString();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese números válidos.", "OK");

                }
                }
                 catch (Exception ex)
                 {
                  Toast.Make($"Error: {ex.Message} no es numero").Show();
                }
            

        }

    }
}
