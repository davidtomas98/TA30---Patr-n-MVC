using System;
using System.Windows.Forms;

namespace Ejercicio1.Views
{
    internal class UpdateView : Form
    {
        private ClienteController _clienteController;
        private int _idCliente;
        private TextBox txtNuevoNombre;
        private TextBox txtNuevoApellido;
        private TextBox txtNuevaDireccion;
        private TextBox txtNuevoDni;
        private DateTimePicker dtpNuevaFecha;
        private Button btnActualizar;

        public UpdateView(ClienteController clienteController, int idCliente)
        {
            _clienteController = clienteController;
            _idCliente = idCliente;
            InitializeComponent();
            CargarDatosCliente();
        }

        private void InitializeComponent()
        {
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.txtNuevoApellido = new System.Windows.Forms.TextBox();
            this.txtNuevaDireccion = new System.Windows.Forms.TextBox();
            this.txtNuevoDni = new System.Windows.Forms.TextBox();
            this.dtpNuevaFecha = new System.Windows.Forms.DateTimePicker();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(20, 20);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(350, 20);
            this.txtNuevoNombre.TabIndex = 0;
            // 
            // txtNuevoApellido
            // 
            this.txtNuevoApellido.Location = new System.Drawing.Point(20, 50);
            this.txtNuevoApellido.Name = "txtNuevoApellido";
            this.txtNuevoApellido.Size = new System.Drawing.Size(350, 20);
            this.txtNuevoApellido.TabIndex = 1;
            // 
            // txtNuevaDireccion
            // 
            this.txtNuevaDireccion.Location = new System.Drawing.Point(20, 80);
            this.txtNuevaDireccion.Name = "txtNuevaDireccion";
            this.txtNuevaDireccion.Size = new System.Drawing.Size(350, 20);
            this.txtNuevaDireccion.TabIndex = 2;
            // 
            // txtNuevoDni
            // 
            this.txtNuevoDni.Location = new System.Drawing.Point(20, 110);
            this.txtNuevoDni.Name = "txtNuevoDni";
            this.txtNuevoDni.Size = new System.Drawing.Size(350, 20);
            this.txtNuevoDni.TabIndex = 3;
            // 
            // dtpNuevaFecha
            // 
            this.dtpNuevaFecha.Location = new System.Drawing.Point(20, 140);
            this.dtpNuevaFecha.Name = "dtpNuevaFecha";
            this.dtpNuevaFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpNuevaFecha.TabIndex = 4;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(20, 170);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // UpdateView
            // 
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.txtNuevoApellido);
            this.Controls.Add(this.txtNuevaDireccion);
            this.Controls.Add(this.txtNuevoDni);
            this.Controls.Add(this.dtpNuevaFecha);
            this.Controls.Add(this.btnActualizar);
            this.Name = "UpdateView";
            this.Text = "Actualizar Cliente";
            this.Load += new System.EventHandler(this.UpdateView_Load);
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
                txtNuevaDireccion.Text = cliente.Direccion; // Cargar la dirección
                txtNuevoDni.Text = cliente.Dni;             // Cargar el DNI
                dtpNuevaFecha.Value = cliente.Fecha;         // Cargar la fecha
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNuevoNombre.Text;
            string nuevoApellido = txtNuevoApellido.Text;
            string nuevaDireccion = txtNuevaDireccion.Text; // Obtener el valor de la dirección
            string nuevoDni = txtNuevoDni.Text;             // Obtener el valor del DNI
            DateTime nuevaFecha = dtpNuevaFecha.Value;       // Obtener el valor de la fecha

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

        private void UpdateView_Load(object sender, EventArgs e)
        {

        }
    }
}
