using System;
using System.Windows.Forms;

namespace Ejercicio1.Views
{
    internal class DeleteView : Form
    {
        private ClienteController _clienteController;
        private int _idCliente;
        private Label lblMensaje;
        private Button btnEliminar;

        public DeleteView(ClienteController clienteController, int idCliente)
        {
            _clienteController = clienteController;
            _idCliente = idCliente;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Crear controles de interfaz gráfica
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
            // DeleteView
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "DeleteView";
            this.Load += new System.EventHandler(this.DeleteView_Load);
            this.ResumeLayout(false);

        }

        private void DeleteView_Load(object sender, EventArgs e)
        {

        }
    }
}
