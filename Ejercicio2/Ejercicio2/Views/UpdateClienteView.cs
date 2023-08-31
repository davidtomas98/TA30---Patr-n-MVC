using System;
using System.Drawing;
using System.Windows.Forms;
using Ejercicio2.Controllers;
using Ejercicio2.Models;

namespace Ejercicio2.Views
{
    internal class UpdateClienteView : Form
    {
        private ClienteController _clienteController;
        private int _idCliente;
        private TextBox txtNuevoNombre;
        private TextBox txtNuevoApellido;
        private TextBox txtNuevaDireccion;
        private TextBox txtNuevoDni;
        private DateTimePicker dtpNuevaFecha;
        private Label lblNuevoNombre;
        private Label lblNuevoApellido;
        private Label lblNuevaDireccion;
        private Label lblNuevoDni;
        private Label lblNuevaFecha;
        private Button btnActualizar;

        public UpdateClienteView(ClienteController clienteController, int idCliente)
        {
            _clienteController = clienteController;
            _idCliente = idCliente;
            InitializeComponent();
            CargarDatosCliente();
            btnActualizar.Click += btnActualizar_Click;
        }

        private void InitializeComponent()
        {
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblNuevoApellido = new System.Windows.Forms.Label();
            this.txtNuevoApellido = new System.Windows.Forms.TextBox();
            this.lblNuevaDireccion = new System.Windows.Forms.Label();
            this.txtNuevaDireccion = new System.Windows.Forms.TextBox();
            this.lblNuevoDni = new System.Windows.Forms.Label();
            this.txtNuevoDni = new System.Windows.Forms.TextBox();
            this.lblNuevaFecha = new System.Windows.Forms.Label();
            this.dtpNuevaFecha = new System.Windows.Forms.DateTimePicker();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.Location = new System.Drawing.Point(20, 20);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNuevoNombre.TabIndex = 0;
            this.lblNuevoNombre.Text = "Nuevo Nombre:";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(150, 20);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNuevoNombre.TabIndex = 1;
            // 
            // lblNuevoApellido
            // 
            this.lblNuevoApellido.Location = new System.Drawing.Point(20, 60);
            this.lblNuevoApellido.Name = "lblNuevoApellido";
            this.lblNuevoApellido.Size = new System.Drawing.Size(100, 23);
            this.lblNuevoApellido.TabIndex = 2;
            this.lblNuevoApellido.Text = "Nuevo Apellido:";
            // 
            // txtNuevoApellido
            // 
            this.txtNuevoApellido.Location = new System.Drawing.Point(150, 60);
            this.txtNuevoApellido.Name = "txtNuevoApellido";
            this.txtNuevoApellido.Size = new System.Drawing.Size(250, 20);
            this.txtNuevoApellido.TabIndex = 3;
            // 
            // lblNuevaDireccion
            // 
            this.lblNuevaDireccion.Location = new System.Drawing.Point(20, 100);
            this.lblNuevaDireccion.Name = "lblNuevaDireccion";
            this.lblNuevaDireccion.Size = new System.Drawing.Size(100, 23);
            this.lblNuevaDireccion.TabIndex = 4;
            this.lblNuevaDireccion.Text = "Nueva Dirección:";
            // 
            // txtNuevaDireccion
            // 
            this.txtNuevaDireccion.Location = new System.Drawing.Point(150, 100);
            this.txtNuevaDireccion.Name = "txtNuevaDireccion";
            this.txtNuevaDireccion.Size = new System.Drawing.Size(250, 20);
            this.txtNuevaDireccion.TabIndex = 5;
            // 
            // lblNuevoDni
            // 
            this.lblNuevoDni.Location = new System.Drawing.Point(20, 140);
            this.lblNuevoDni.Name = "lblNuevoDni";
            this.lblNuevoDni.Size = new System.Drawing.Size(100, 23);
            this.lblNuevoDni.TabIndex = 6;
            this.lblNuevoDni.Text = "Nuevo DNI:";
            // 
            // txtNuevoDni
            // 
            this.txtNuevoDni.Location = new System.Drawing.Point(150, 140);
            this.txtNuevoDni.Name = "txtNuevoDni";
            this.txtNuevoDni.Size = new System.Drawing.Size(250, 20);
            this.txtNuevoDni.TabIndex = 7;
            // 
            // lblNuevaFecha
            // 
            this.lblNuevaFecha.Location = new System.Drawing.Point(20, 180);
            this.lblNuevaFecha.Name = "lblNuevaFecha";
            this.lblNuevaFecha.Size = new System.Drawing.Size(100, 23);
            this.lblNuevaFecha.TabIndex = 8;
            this.lblNuevaFecha.Text = "Nueva Fecha:";
            // 
            // dtpNuevaFecha
            // 
            this.dtpNuevaFecha.Location = new System.Drawing.Point(150, 180);
            this.dtpNuevaFecha.Name = "dtpNuevaFecha";
            this.dtpNuevaFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpNuevaFecha.TabIndex = 9;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(20, 220);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // UpdateClienteView
            // 
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.lblNuevoApellido);
            this.Controls.Add(this.txtNuevoApellido);
            this.Controls.Add(this.lblNuevaDireccion);
            this.Controls.Add(this.txtNuevaDireccion);
            this.Controls.Add(this.lblNuevoDni);
            this.Controls.Add(this.txtNuevoDni);
            this.Controls.Add(this.lblNuevaFecha);
            this.Controls.Add(this.dtpNuevaFecha);
            this.Controls.Add(this.btnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateClienteView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Cliente";
            this.Load += new System.EventHandler(this.UpdateClienteView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CargarDatosCliente()
        {
            Cliente cliente = _clienteController.ObtenerClientePorId(_idCliente);
            if (cliente != null)
            {
                txtNuevoNombre.Text = cliente.Nombre;
                txtNuevoApellido.Text = cliente.Apellido;
                txtNuevaDireccion.Text = cliente.Direccion;
                txtNuevoDni.Text = cliente.Dni;
                dtpNuevaFecha.Value = cliente.Fecha;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNuevoNombre.Text;
            string nuevoApellido = txtNuevoApellido.Text;
            string nuevaDireccion = txtNuevaDireccion.Text;
            string nuevoDni = txtNuevoDni.Text;
            DateTime nuevaFecha = dtpNuevaFecha.Value;

            if (!string.IsNullOrWhiteSpace(nuevoNombre) && !string.IsNullOrWhiteSpace(nuevoApellido) &&
                !string.IsNullOrWhiteSpace(nuevaDireccion) && !string.IsNullOrWhiteSpace(nuevoDni))
            {
                Cliente clienteActualizado = new Cliente
                {
                    Id = _idCliente,
                    Nombre = nuevoNombre,
                    Apellido = nuevoApellido,
                    Direccion = nuevaDireccion,
                    Dni = nuevoDni,
                    Fecha = nuevaFecha
                };

                _clienteController.ActualizarCliente(clienteActualizado);
                MessageBox.Show("Cliente actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateClienteView_Load(object sender, EventArgs e)
        {

        }
    }
}
