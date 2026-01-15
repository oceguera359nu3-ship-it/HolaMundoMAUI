using System;
using System.Collections.Generic;
using System.Text;

namespace HolaMundoInicioSesion.Services
{
    public class InicioDeSesionService
    {
        public bool IniciarSesion(string usuario, string contrasena)
        {
            // Lógica simple de autenticación para demostración
            if(usuario == "admin" && contrasena == "password")
            {
                return true;
            }
        }
    }
}
