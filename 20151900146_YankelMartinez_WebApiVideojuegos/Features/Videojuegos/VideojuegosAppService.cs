using _20151900146_YankelMartinez_WebApiVideojuegos.Entities;

namespace _20251900146_YankelMartinez_WebApiVideojuegos.Features.Videojuegos
{
    public class VideojuegosAppService
    {
        private List<Videojuego> videojuegos = new List<Videojuego>();
        private VideojuegosDomainService domain;

        public VideojuegosAppService()
        {
            videojuegos.Add(new Videojuego { Id = 1, Nombre = "Fortnite", Genero = "Shooter", Plataforma = "PC/PS5", Desarrollador = "Epic Games", FechaLanzamiento = new DateTime(2017, 7, 25) });
            videojuegos.Add(new Videojuego { Id = 2, Nombre = "FIFA 25", Genero = "Deportes", Plataforma = "PS5/Xbox", Desarrollador = "EA Sports", FechaLanzamiento = new DateTime(2024, 9, 27) });
            videojuegos.Add(new Videojuego { Id = 3, Nombre = "GTA V", Genero = "Accion", Plataforma = "PC/PS5", Desarrollador = "Rockstar Games", FechaLanzamiento = new DateTime(2013, 9, 17) });
            videojuegos.Add(new Videojuego { Id = 4, Nombre = "Minecraft", Genero = "Sandbox", Plataforma = "PC/Mobile", Desarrollador = "Mojang", FechaLanzamiento = new DateTime(2011, 11, 18) });
            videojuegos.Add(new Videojuego { Id = 5, Nombre = "Call of Duty Warzone", Genero = "Shooter", Plataforma = "PC/PS5", Desarrollador = "Activision", FechaLanzamiento = new DateTime(2020, 3, 10) });

            domain = new VideojuegosDomainService();
        }

        // Obtener todos los videojuegos
        public List<Videojuego> ObtenerVideojuegos()
        {
            return videojuegos;
        }

        // Obtener videojuego por ID
        public Videojuego ObtenerVideojuegoPorId(int id)
        {
            return videojuegos.Where(x => x.Id == id).First();
        }

        // Agregar un nuevo videojuego
        public void GuardarVideojuego(Videojuego videojuego)
        {
            if (!domain.GuardarVideojuego(videojuego))
            {
                return;
            }
            videojuegos.Add(videojuego);
        }

        // Actualizar un videojuego existente
        public void ActualizarVideojuego(Videojuego videojuego)
        {
            Videojuego? existente = videojuegos.Where(x => x.Id == videojuego.Id).FirstOrDefault();

            if (existente == null)
            {
                return;
            }

            existente.Nombre = videojuego.Nombre;
            existente.Genero = videojuego.Genero;
            existente.Plataforma = videojuego.Plataforma;
            existente.Desarrollador = videojuego.Desarrollador;
            existente.FechaLanzamiento = videojuego.FechaLanzamiento;
        }

        // Eliminar un videojuego
        public void EliminarVideojuego(int id)
        {
            videojuegos.RemoveAll(x => x.Id == id);
        }
    }
}