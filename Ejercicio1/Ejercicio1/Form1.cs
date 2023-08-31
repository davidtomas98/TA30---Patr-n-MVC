using Ejercicio1.Views; // Importar espacio de nombres necesario
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private ClienteController _clienteController; // Controlador para manejar los clientes

        public Form1()
        {
            InitializeComponent();
            _clienteController = new ClienteController(); // Inicializar el controlador de clientes
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarListaClientes(); // Actualizar la lista de clientes al cargar el formulario
        }

        private void ActualizarListaClientes()
        {
            lstClientes.Items.Clear(); // Limpiar la lista actual
            List<Cliente> clientes = _clienteController.ObtenerClientes(); // Obtener la lista de clientes desde el controlador

            foreach (Cliente cliente in clientes)
            {
                lstClientes.Items.Add(cliente.Nombre); // Agregar los nombres de los clientes a la lista
            }
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex != -1)
            {
                int idCliente = lstClientes.SelectedIndex; // Obtener el índice del cliente seleccionado en la lista
                Cliente cliente = _clienteController.ObtenerClientePorId(idCliente); // Obtener los detalles del cliente

                if (cliente != null)
                {
                    // Crear un mensaje con la información del cliente y mostrarlo en un cuadro de diálogo
                    string infoCliente = $"Nombre: {cliente.Nombre}\nApellido: {cliente.Apellido}\nDirección: {cliente.Direccion}\nDNI: {cliente.Dni}\nFecha: {cliente.Fecha}";
                    MessageBox.Show(infoCliente, "Información del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CrearCliente()
        {
            CreateView createView = new CreateView(_clienteController); // Crear una instancia de la vista de creación de cliente
            createView.ShowDialog(); // Mostrar la vista como un cuadro de diálogo
            ActualizarListaClientes(); // Actualizar la lista de clientes después de la creación
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearCliente(); // Manejar el evento de clic en el botón Crear
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex != -1)
            {
                int idCliente = lstClientes.SelectedIndex; // Obtener el índice del cliente seleccionado
                UpdateView updateView = new UpdateView(_clienteController, idCliente); // Crear una instancia de la vista de actualización
                updateView.ShowDialog(); // Mostrar la vista como un cuadro de diálogo
                ActualizarListaClientes(); // Actualizar la lista de clientes después de la actualización
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente de la lista para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex != -1)
            {
                int idCliente = lstClientes.SelectedIndex; // Obtener el índice del cliente seleccionado
                DeleteView deleteView = new DeleteView(_clienteController, idCliente); // Crear una instancia de la vista de eliminación
                deleteView.ShowDialog(); // Mostrar la vista como un cuadro de diálogo
                ActualizarListaClientes(); // Actualizar la lista de clientes después de la eliminación
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente de la lista para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarListaClientes(); // Manejar la opción de menú "Listar Clientes"
        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCliente(); // Manejar la opción de menú "Crear Cliente"
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnActualizar_Click(sender, e); // Manejar la opción de menú "Modificar Cliente"
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEliminar_Click(sender, e); // Manejar la opción de menú "Eliminar Cliente"
        }
    }
}
