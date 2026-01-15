namespace HolaMundo.Toast01
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
          Toast.Show("Hola Mundo desde MAUI");
        }
    }
}
