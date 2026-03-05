using _20151900146_YankelMartinez_WebApiVideojuegos.Entities;

namespace _20251900146_YankelMartinez_WebApiVideojuegos.Features.Videojuegos
{
    public class VideojuegosDomainService
    {
        public VideojuegosDomainService() { }

        // Validaciones al momento de agregar un nuevo videojuego
        public bool GuardarVideojuego(Videojuego videojuego)
        {
            if (string.IsNullOrEmpty(videojuego.Nombre) ||
                string.IsNullOrEmpty(videojuego.Desarrollador))
            {
                return false;
            }

            return true;
        }
    }
}