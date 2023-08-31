using System;
using System.Drawing;
using System.Windows.Forms;
using Ejercicio2.Controllers;
using Ejercicio2.Models;

namespace Ejercicio2.Views
{
    internal class CreateVideoView : Form
    {
        private VideoController _videoController;
        private TextBox txtTitle;
        private TextBox txtDirector;
        private TextBox txtCliId;
        private Button btnCrear;

        public CreateVideoView(VideoController videoController)
        {
            _videoController = videoController;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Configuración de la ventana
            Text = "Crear Video";
            Width = 400;
            Height = 250;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;

            // Crear controles de interfaz gráfica
            Label lblTitle = new Label();
            lblTitle.Text = "Título:";
            lblTitle.Location = new Point(20, 20);
            Controls.Add(lblTitle);

            txtTitle = new TextBox();
            txtTitle.Location = new Point(120, 20);
            txtTitle.Width = 250;
            Controls.Add(txtTitle);

            Label lblDirector = new Label();
            lblDirector.Text = "Director:";
            lblDirector.Location = new Point(20, 60);
            Controls.Add(lblDirector);

            txtDirector = new TextBox();
            txtDirector.Location = new Point(120, 60);
            txtDirector.Width = 250;
            Controls.Add(txtDirector);

            Label lblCliId = new Label();
            lblCliId.Text = "ID Cliente:";
            lblCliId.Location = new Point(20, 100);
            Controls.Add(lblCliId);

            txtCliId = new TextBox();
            txtCliId.Location = new Point(120, 100);
            txtCliId.Width = 250;
            Controls.Add(txtCliId);

            btnCrear = new Button();
            btnCrear.Text = "Crear";
            btnCrear.Location = new Point(20, 140);
            btnCrear.Font = new Font(btnCrear.Font.FontFamily, btnCrear.Font.Size, FontStyle.Bold);
            btnCrear.Click += btnCrear_Click;
            Controls.Add(btnCrear);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string director = txtDirector.Text;
            string cliIdString = txtCliId.Text;

            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(director) && int.TryParse(cliIdString, out int cliId))
            {
                Video nuevoVideo = new Video
                {
                    Title = title,
                    Director = director,
                    ClienteId = cliId
                };

                _videoController.CrearVideo(nuevoVideo);
                MessageBox.Show("Video creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa datos válidos en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CreateVideoView
            // 
            this.ClientSize = new System.Drawing.Size(400, 190);
            this.Name = "CreateVideoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Video";
            this.Load += new System.EventHandler(this.CreateVideoView_Load);
            this.ResumeLayout(false);

        }

        private void CreateVideoView_Load(object sender, EventArgs e)
        {

        }
    }
}
