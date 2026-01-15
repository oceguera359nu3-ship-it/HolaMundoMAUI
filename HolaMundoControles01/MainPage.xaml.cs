namespace HolaMundoControles01
{
    public partial class MainPage : ContentPage
    {
   

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string nombre = EntryNombre.Text;
            int edad = Convert.ToInt32(EntryEdad.Text);
            LabelResultado.Text= nombre + " " + edad + " " + "Años";
  
        }
    }
}
