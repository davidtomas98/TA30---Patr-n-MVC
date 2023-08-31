using System;
using System.Windows.Forms;
using Ejercicio2.Controllers;
using Ejercicio2.Models;

namespace Ejercicio2.Views
{
    internal class EliminarClienteView : Form
    {
        private ClienteController _clienteController;
        private int _idCliente;
        private Label lblMensaje;
        private Button btnEliminar;

        public EliminarClienteView(ClienteController clienteController, int idCliente)
        {
            _clienteController = clienteController;
            _idCliente = idCliente;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Configuración de la ventana
            Text = "Eliminar Cliente";
            Width = 300;

            lblMensaje = new Label();
            lblMensaje.Text = "¿Estás seguro de que deseas eliminar este cliente?";
            lblMensaje.Location = new System.Drawing.Point(20, 20);
            lblMensaje.Width = 250;
            Controls.Add(lblMensaje);

            btnEliminar = new Button();
            btnEliminar.Text = "Eliminar";
            btnEliminar.Location = new System.Drawing.Point(20, 50);
            btnEliminar.Click += btnEliminar_Click;
            Controls.Add(btnEliminar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                _clienteController.EliminarCliente(_idCliente);
                MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EliminarClienteView
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "EliminarClienteView";
            this.Load += new System.EventHandler(this.EliminarClienteView_Load);
            this.ResumeLayout(false);

        }

        private void EliminarClienteView_Load(object sender, EventArgs e)
        {

        }
    }
}
