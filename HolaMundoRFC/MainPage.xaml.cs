namespace HolaMundoRFC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            string name = NombreEntry.Text;
            string lastName1 = PrimerApellidoEntry.Text;
            string lastName2 = SegundoApellidoEntry.Text;
            DateTime ? birthDate = FechaNacimientoPicker.Date;

            if (birthDate == null)
            {
                await DisplayAlert("Error", "Por favor, seleccione una fecha de nacimiento válida.", "OK");
                return;
            }

            // Validar que los campos no estén vacíos (puedes añadir validaciones más robustas)
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName1) || string.IsNullOrWhiteSpace(lastName2))
            {
                await DisplayAlert("Error", "Por favor, complete todos los campos de nombre y apellidos.", "OK");
                return;
            }

            // Aquí puedes procesar los datos, por ejemplo, guardarlos en una base de datos o mostrarlos.
            string message = $"Datos guardados:\n" +
                             $"Nombre: {name} {lastName1} {lastName2}\n" +
                             $"Fecha de Nacimiento: {birthDate:dd/MM/yyyy}";

            await DisplayAlert("Éxito", message, "OK");
        }


        private void OnCounterClicked(object? sender, EventArgs e)
        {

        }
    }
}
