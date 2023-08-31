using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio1.Views
{
    internal class CreateView : Form
    {
        private ClienteController _clienteController;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtDni;
        private DateTimePicker datePicker;
        private Button btnCrear;

        public CreateView(ClienteController clienteController)
        {
            _clienteController = clienteController;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Configuración de la ventana
            Text = "Crear Cliente";
            Width = 400;
            Height = 400;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;

            // Crear controles de interfaz gráfica
            Label lblNombre = new Label();
            lblNombre.Text = "Nombre:";
            lblNombre.Location = new Point(20, 20);
            Controls.Add(lblNombre);

            txtNombre = new TextBox();
            txtNombre.Location = new Point(120, 20);
            txtNombre.Width = 250;
            Controls.Add(txtNombre);

            Label lblApellido = new Label();
            lblApellido.Text = "Apellido:";
            lblApellido.Location = new Point(20, 60);
            Controls.Add(lblApellido);

            txtApellido = new TextBox();
            txtApellido.Location = new Point(120, 60);
            txtApellido.Width = 250;
            Controls.Add(txtApellido);

            Label lblDireccion = new Label();
            lblDireccion.Text = "Dirección:";
            lblDireccion.Location = new Point(20, 100);
            Controls.Add(lblDireccion);

            txtDireccion = new TextBox();
            txtDireccion.Location = new Point(120, 100);
            txtDireccion.Width = 250;
            Controls.Add(txtDireccion);

            Label lblDni = new Label();
            lblDni.Text = "DNI:";
            lblDni.Location = new Point(20, 140);
            Controls.Add(lblDni);

            txtDni = new TextBox();
            txtDni.Location = new Point(120, 140);
            txtDni.Width = 250;
            Controls.Add(txtDni);

            Label lblFecha = new Label();
            lblFecha.Text = "Fecha:";
            lblFecha.Location = new Point(20, 180);
            Controls.Add(lblFecha);

            datePicker = new DateTimePicker();
            datePicker.Location = new Point(120, 180);
            datePicker.Width = 200;
            Controls.Add(datePicker);

            btnCrear = new Button();
            btnCrear.Text = "Crear";
            btnCrear.Location = new Point(20, 220);
            btnCrear.Font = new Font(btnCrear.Font.FontFamily, btnCrear.Font.Size, FontStyle.Bold);
            btnCrear.Click += btnCrear_Click;
            Controls.Add(btnCrear);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string dniString = txtDni.Text;

            if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellido) && !string.IsNullOrWhiteSpace(direccion) && int.TryParse(dniString, out int dni))
            {
                DateTime fecha = datePicker.Value;

                Cliente nuevoCliente = new Cliente
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Direccion = direccion,
                    Dni = dni.ToString(),
                    Fecha = fecha
                };

                _clienteController.CrearCliente(nuevoCliente);
                MessageBox.Show("Cliente creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // CreateView
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "CreateView";
            this.Load += new System.EventHandler(this.CreateView_Load);
            this.ResumeLayout(false);

        }

        private void CreateView_Load(object sender, EventArgs e)
        {

        }
    }
}
