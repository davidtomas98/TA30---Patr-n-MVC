using System;
using System.Collections.Generic;
using Ejercicio2.Models;

namespace Ejercicio2.Controllers
{
    public class ClienteController
    {
        private List<Cliente> _clientes = new List<Cliente>();

        // Método para crear un nuevo cliente
        public void CrearCliente(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        // Método para obtener la lista de todos los clientes
        public List<Cliente> ObtenerClientes()
        {
            return _clientes;
        }

        // Método para obtener un cliente por su ID
        public Cliente ObtenerClientePorId(int id)
        {
            return _clientes.Find(c => c.Id == id);
        }

        // Método para actualizar la información de un cliente
        public void ActualizarCliente(Cliente clienteActualizado)
        {
            Cliente clienteExistente = _clientes.Find(c => c.Id == clienteActualizado.Id);
            if (clienteExistente != null)
            {
                // Actualizar los datos del cliente existente con los datos del cliente actualizado
                clienteExistente.Nombre = clienteActualizado.Nombre;
                clienteExistente.Apellido = clienteActualizado.Apellido;
                clienteExistente.Direccion = clienteActualizado.Direccion;
                clienteExistente.Dni = clienteActualizado.Dni;
                clienteExistente.Fecha = clienteActualizado.Fecha;
            }
        }

        // Método para eliminar un cliente por su ID
        public void EliminarCliente(int id)
        {
            Cliente clienteExistente = _clientes.Find(c => c.Id == id);
            if (clienteExistente != null)
            {
                // Remover el cliente de la lista
                _clientes.Remove(clienteExistente);
            }
        }
    }
}
