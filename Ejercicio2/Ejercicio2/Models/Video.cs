using System;

namespace Ejercicio2.Models
{
    // Definición de la clase Video
    public class Video
    {
        // Propiedades de la clase Video

        // ID del video
        public int Id { get; set; }

        // Título del video
        public string Title { get; set; }

        // Director del video
        public string Director { get; set; }

        // ID del cliente asociado al video
        public int ClienteId { get; set; }
    }
}
