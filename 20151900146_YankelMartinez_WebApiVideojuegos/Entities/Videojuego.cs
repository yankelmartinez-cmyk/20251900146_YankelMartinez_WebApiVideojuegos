namespace _20151900146_YankelMartinez_WebApiVideojuegos.Entities
{
    public class Videojuego
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Plataforma { get; set; }
        public string Desarrollador { get; set; }
        public DateTime FechaLanzamiento { get; set; }
    }
}
