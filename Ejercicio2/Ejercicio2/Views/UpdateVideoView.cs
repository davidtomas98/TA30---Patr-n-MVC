using System;
using System.Drawing;
using System.Windows.Forms;
using Ejercicio2.Controllers;
using Ejercicio2.Models;

namespace Ejercicio2.Views
{
    internal class UpdateVideoView : Form
    {
        private VideoController _videoController;
        private int _idVideo;
        private TextBox txtNuevoTitle;
        private TextBox txtNuevoDirector;
        private TextBox txtNuevoCliId;
        private Label lblNuevoTitle;
        private Label lblNuevoDirector;
        private Label lblNuevoCliId;
        private Button btnActualizar;

        public UpdateVideoView(VideoController videoController, int idVideo)
        {
            _videoController = videoController;
            _idVideo = idVideo;
            InitializeComponent();
            CargarDatosVideo();
            btnActualizar.Click += btnActualizar_Click;

        }

        private void InitializeComponent()
        {
            this.lblNuevoTitle = new System.Windows.Forms.Label();
            this.txtNuevoTitle = new System.Windows.Forms.TextBox();
            this.lblNuevoDirector = new System.Windows.Forms.Label();
            this.txtNuevoDirector = new System.Windows.Forms.TextBox();
            this.lblNuevoCliId = new System.Windows.Forms.Label();
            this.txtNuevoCliId = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevoTitle
            // 
            this.lblNuevoTitle.Location = new System.Drawing.Point(20, 20);
            this.lblNuevoTitle.Name = "lblNuevoTitle";
            this.lblNuevoTitle.Size = new System.Drawing.Size(100, 23);
            this.lblNuevoTitle.TabIndex = 0;
            this.lblNuevoTitle.Text = "Nuevo Título:";
            // 
            // txtNuevoTitle
            // 
            this.txtNuevoTitle.Location = new System.Drawing.Point(150, 20);
            this.txtNuevoTitle.Name = "txtNuevoTitle";
            this.txtNuevoTitle.Size = new System.Drawing.Size(250, 20);
            this.txtNuevoTitle.TabIndex = 1;
            // 
            // lblNuevoDirector
            // 
            this.lblNuevoDirector.Location = new System.Drawing.Point(20, 60);
            this.lblNuevoDirector.Name = "lblNuevoDirector";
            this.lblNuevoDirector.Size = new System.Drawing.Size(100, 23);
            this.lblNuevoDirector.TabIndex = 2;
            this.lblNuevoDirector.Text = "Nuevo Director:";
            // 
            // txtNuevoDirector
            // 
            this.txtNuevoDirector.Location = new System.Drawing.Point(150, 60);
            this.txtNuevoDirector.Name = "txtNuevoDirector";
            this.txtNuevoDirector.Size = new System.Drawing.Size(250, 20);
            this.txtNuevoDirector.TabIndex = 3;
            // 
            // lblNuevoCliId
            // 
            this.lblNuevoCliId.Location = new System.Drawing.Point(20, 100);
            this.lblNuevoCliId.Name = "lblNuevoCliId";
            this.lblNuevoCliId.Size = new System.Drawing.Size(100, 23);
            this.lblNuevoCliId.TabIndex = 4;
            this.lblNuevoCliId.Text = "Nuevo ID Cliente:";
            // 
            // txtNuevoCliId
            // 
            this.txtNuevoCliId.Location = new System.Drawing.Point(150, 100);
            this.txtNuevoCliId.Name = "txtNuevoCliId";
            this.txtNuevoCliId.Size = new System.Drawing.Size(250, 20);
            this.txtNuevoCliId.TabIndex = 5;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(20, 140);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // UpdateVideoView
            // 
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lblNuevoTitle);
            this.Controls.Add(this.txtNuevoTitle);
            this.Controls.Add(this.lblNuevoDirector);
            this.Controls.Add(this.txtNuevoDirector);
            this.Controls.Add(this.lblNuevoCliId);
            this.Controls.Add(this.txtNuevoCliId);
            this.Controls.Add(this.btnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateVideoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Video";
            this.Load += new System.EventHandler(this.UpdateVideoView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CargarDatosVideo()
        {
            Video video = _videoController.ObtenerVideoPorId(_idVideo);
            if (video != null)
            {
                txtNuevoTitle.Text = video.Title;
                txtNuevoDirector.Text = video.Director;
                txtNuevoCliId.Text = video.ClienteId.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nuevoTitle = txtNuevoTitle.Text;
            string nuevoDirector = txtNuevoDirector.Text;
            string nuevoCliIdString = txtNuevoCliId.Text;

            if (!string.IsNullOrWhiteSpace(nuevoTitle) && !string.IsNullOrWhiteSpace(nuevoDirector) &&
                int.TryParse(nuevoCliIdString, out int nuevoCliId))
            {
                Video videoActualizado = new Video
                {
                    Id = _idVideo,
                    Title = nuevoTitle,
                    Director = nuevoDirector,
                    ClienteId = nuevoCliId
                };

                _videoController.ActualizarVideo(videoActualizado);
                MessageBox.Show("Video actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateVideoView_Load(object sender, EventArgs e)
        {

        }
    }
}
