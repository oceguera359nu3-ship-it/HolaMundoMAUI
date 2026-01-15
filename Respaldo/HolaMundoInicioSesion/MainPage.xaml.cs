
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using HolaMundoInicioSesion.Services;

namespace HolaMundoInicioSesion
{
    public partial class MainPage : ContentPage
    {
        InicioDeSesionService _services;

        public MainPage(InicioDeSesionService inicioDeSesionService)
        {
            InitializeComponent();
            _services = inicioDeSesionService;
        }

        private void Button_Clicked(object? sender, EventArgs e)
        {
            string usuario;
            string contrasena;
            bool resultado;


            usuario = EntryUsuario.Text;
            contrasena = EntryContrasena.Text;
            resultado = _services.IniciarSesion(usuario, contrasena);

            if (resultado)
            {
                Toast.Make("Bienvenido " + usuario, ToastDuration.Long,14).Show();
            }
            else
            {
                Toast.Make("Usuario y/o contraseña son incorrectas ",ToastDuration.Long,14).Show();
            }
            }
    }
}
