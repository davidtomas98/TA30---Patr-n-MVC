using System.Collections.Generic;

public class ClienteController
{
    private List<Cliente> _clientes = new List<Cliente>(); // Simulación de datos en memoria

    public void CrearCliente(Cliente cliente)
    {
        _clientes.Add(cliente); // Agregar el nuevo cliente a la lista
    }

    public List<Cliente> ObtenerClientes()
    {
        return _clientes; // Devolver la lista de clientes
    }

    public Cliente ObtenerClientePorId(int id)
    {
        return _clientes.Find(c => c.Id == id);
    }

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

    public void EliminarCliente(int id)
    {
        Cliente clienteExistente = _clientes.Find(c => c.Id == id);
        if (clienteExistente != null)
        {
            _clientes.Remove(clienteExistente); // Eliminar el cliente de la lista
        }
    }
}
