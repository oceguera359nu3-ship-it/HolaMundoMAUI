
namespace HolaMundo.Imagen
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            Image.Source = "https://images.pexels.com/photos/66898/elephant-cub-tsavo-kenya-66898.jpeg";

        }
    }
}
