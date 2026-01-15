namespace HolaMundoRFC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName1))
            {
                // LabelResultadoRfc.Text = "Por favor, complete al menos el nombre y el primer apellido.";
               // return;
            }

            await DisplayAlert("Éxito", message, "OK");



            // Lógica básica para generar la parte principal del RFC (sin homoclave SAT final)
            string rfc = GenerarRfcInicial(name, lastName1, lastName2, (DateTime)birthDate);
            string LabelResultadoRfc = $"RFC (incompleto sin homoclave SAT final): {rfc}";

        }


        private string GenerarRfcInicial(string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento)
        {
            // Tomar la primera letra del primer apellido y la primera vocal interna
            string parteAlfabetica = "";
            if (!string.IsNullOrEmpty(primerApellido))
            {
                parteAlfabetica += primerApellido[0];
                foreach (char c in primerApellido.Substring(1))
                {
                    if ("AEIOU".Contains(c))
                    {
                        parteAlfabetica += c;
                        break;
                    }
                }
            }

            // Tomar la primera letra del segundo apellido
            if (!string.IsNullOrEmpty(segundoApellido))
            {
                parteAlfabetica += segundoApellido[0];
            }
            else
            {
                // Si no hay segundo apellido, usar 'X' o la segunda letra del primer apellido (reglas específicas)
                // Usaremos una X simple para este ejemplo simplificado.
                parteAlfabetica += 'X';
            }

            // Tomar la primera letra del nombre
            parteAlfabetica += nombre[0];

            // Manejar palabras inconvenientes (regla del SAT)
            string[] palabrasInconvenientes = { "BUEI", "BUEY", "CACA", "CACO", "CAGA", "CAGO", "CAKA", "CAKO", "COGE", "COJA", "COJE", "COJO", "CULO", "FETO", "GUEY", "JOTO", "KACA", "KACO", "KAGA", "KAGO", "KAKA", "KAKO", "KOGE", "KOJO", "KULO", "MAME", "MAMO", "MEAR", "MEAS", "MEON", "MIAR", "MIAS", "MION", "MOCO", "MOKO", "NACA", "NACO", "PEDA", "PEDO", "PENE", "PIPI", "PITO", "POPO", "PUTA", "PUTO", "QULO", "RATA", "ROBA", "ROBO", "RUIN", "SENO", "TETA", "VUEY", "WEYS" };
            if (palabrasInconvenientes.Contains(parteAlfabetica))
            {
                parteAlfabetica = parteAlfabetica.Substring(0, 3) + "X"; // Reemplazar la última letra con X
            }

            // Formatear la fecha de nacimiento AAMMDD
            string fechaParte = fechaNacimiento.ToString("yyMMdd");

            // Concatenar y convertir a mayúsculas
            return (parteAlfabetica + fechaParte).ToUpper();
        }
    


    }
}
