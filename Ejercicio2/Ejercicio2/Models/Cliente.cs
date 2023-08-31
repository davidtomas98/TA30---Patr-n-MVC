using System;

namespace Ejercicio2.Models
{
    public class Cliente
    {
        // Propiedad para almacenar el ID del cliente
        public int Id { get; set; }

        // Propiedad para almacenar el nombre del cliente
        public string Nombre { get; set; }

        // Propiedad para almacenar el apellido del cliente
        public string Apellido { get; set; }

        // Propiedad para almacenar la dirección del cliente
        public string Direccion { get; set; }

        // Propiedad para almacenar el número de DNI del cliente
        public string Dni { get; set; }

        // Propiedad para almacenar la fecha de registro del cliente
        public DateTime Fecha { get; set; }
    }
}
