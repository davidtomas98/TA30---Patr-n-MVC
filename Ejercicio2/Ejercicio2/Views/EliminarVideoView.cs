using System;
using System.Windows.Forms;
using Ejercicio2.Controllers;
using Ejercicio2.Models;

namespace Ejercicio2.Views
{
    internal class EliminarVideoView : Form
    {
        private VideoController _videoController;
        private int _videoAEliminar;
        private Label lblMensaje;
        private Button btnEliminar;

        public EliminarVideoView(VideoController videoController, int videoAEliminar)
        {
            _videoController = videoController;
            _videoAEliminar = videoAEliminar;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Configuración de la ventana
            Text = "Eliminar Video";
            Width = 300;

            lblMensaje = new Label();
            lblMensaje.Text = "¿Estás seguro de que deseas eliminar este video?";
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
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este video?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                _videoController.EliminarVideo(_videoAEliminar);
                MessageBox.Show("Video eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EliminarVideoView
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnEliminar);
            this.Name = "EliminarVideoView";
            this.Text = "Eliminar Video";
            this.Load += new System.EventHandler(this.EliminarVideoView_Load);
            this.ResumeLayout(false);

        }

        private void EliminarVideoView_Load(object sender, EventArgs e)
        {

        }
    }
}
