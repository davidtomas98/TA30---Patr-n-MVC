using System;
using System.Drawing;
using System.Windows.Forms;
using Ejercicio2.Controllers;
using Ejercicio2.Models;
using Ejercicio2.Views;

namespace EjemploApp
{
    public partial class Form1 : Form
    {
        private ClienteController _clienteController = new ClienteController();
        private VideoController _videoController = new VideoController();
        private ListBox lstClientes;
        private ListBox lstVideos;

        public Form1()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Padding = new Padding(20);
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            Controls.Add(tableLayoutPanel);

            InitializeClientesPanel(tableLayoutPanel);
            InitializeVideosPanel(tableLayoutPanel);

            // Actualizar la lista de clientes y videos al cargar el formulario
            ActualizarListaClientes();
            ActualizarListaVideos();
        }

        private void InitializeClientesPanel(TableLayoutPanel parentPanel)
        {
            GroupBox groupBoxClientes = new GroupBox();
            groupBoxClientes.Text = "Clientes";
            groupBoxClientes.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(groupBoxClientes, 0, 0);

            FlowLayoutPanel panelClientes = new FlowLayoutPanel();
            panelClientes.Dock = DockStyle.Fill;
            panelClientes.FlowDirection = FlowDirection.TopDown;
            groupBoxClientes.Controls.Add(panelClientes);

            lstClientes = new ListBox();
            lstClientes.Size = new Size(200, 150);
            panelClientes.Controls.Add(lstClientes);

            Button btnCrearCliente = CreateStyledButton("Crear Cliente", btnCrearCliente_Click);
            panelClientes.Controls.Add(btnCrearCliente);

            Button btnLeerCliente = CreateStyledButton("Leer Cliente", btnLeerCliente_Click);
            panelClientes.Controls.Add(btnLeerCliente);

            Button btnActualizarCliente = CreateStyledButton("Actualizar Cliente", btnActualizarCliente_Click);
            panelClientes.Controls.Add(btnActualizarCliente);

            Button btnEliminarCliente = CreateStyledButton("Eliminar Cliente", btnEliminarCliente_Click);
            panelClientes.Controls.Add(btnEliminarCliente);
        }

        private void InitializeVideosPanel(TableLayoutPanel parentPanel)
        {
            GroupBox groupBoxVideos = new GroupBox();
            groupBoxVideos.Text = "Videos";
            groupBoxVideos.Dock = DockStyle.Fill;
            parentPanel.Controls.Add(groupBoxVideos, 1, 0);

            FlowLayoutPanel panelVideos = new FlowLayoutPanel();
            panelVideos.Dock = DockStyle.Fill;
            panelVideos.FlowDirection = FlowDirection.TopDown;
            groupBoxVideos.Controls.Add(panelVideos);

            lstVideos = new ListBox();
            lstVideos.Size = new Size(200, 150);
            panelVideos.Controls.Add(lstVideos);

            Button btnCrearVideo = CreateStyledButton("Crear Video", btnCrearVideo_Click);
            panelVideos.Controls.Add(btnCrearVideo);

            Button btnLeerVideo = CreateStyledButton("Leer Video", btnLeerVideo_Click);
            panelVideos.Controls.Add(btnLeerVideo);

            Button btnActualizarVideo = CreateStyledButton("Actualizar Video", btnActualizarVideo_Click);
            panelVideos.Controls.Add(btnActualizarVideo);

            Button btnEliminarVideo = CreateStyledButton("Eliminar Video", btnEliminarVideo_Click);
            panelVideos.Controls.Add(btnEliminarVideo);
        }

        private Button CreateStyledButton(string text, EventHandler clickHandler)
        {
            Button button = new Button();
            button.Text = text;
            button.Size = new Size(150, 30);
            button.Click += clickHandler;
            return button;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ActualizarListaClientes();
            ActualizarListaVideos();
        }

        private void ActualizarListaVideos()
        {
            lstVideos.Items.Clear();
            foreach (Video video in _videoController.ObtenerVideos())
            {
                lstVideos.Items.Add(video.Title);
            }
        }


        private void ActualizarListaClientes()
        {
            lstClientes.Items.Clear();
            foreach (Cliente cliente in _clienteController.ObtenerClientes())
            {
                lstClientes.Items.Add(cliente.Nombre);
            }
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            CreateClienteView createClienteView = new CreateClienteView(_clienteController);
            createClienteView.ShowDialog();
            ActualizarListaClientes();
        }

        private void btnCrearVideo_Click(object sender, EventArgs e)
        {
            CreateVideoView createVideoView = new CreateVideoView(_videoController);
            createVideoView.ShowDialog();
            ActualizarListaVideos();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex != -1)
            {
                int idCliente = lstClientes.SelectedIndex;
                EliminarClienteView eliminarClienteView = new EliminarClienteView(_clienteController, idCliente);
                eliminarClienteView.ShowDialog();
                ActualizarListaClientes();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente de la lista para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex != -1)
            {
                int idCliente = lstClientes.SelectedIndex;
                UpdateClienteView updateClienteView = new UpdateClienteView(_clienteController, idCliente);
                updateClienteView.ShowDialog();
                ActualizarListaClientes();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente de la lista para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeerCliente_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex != -1)
            {
                int idCliente = lstClientes.SelectedIndex;
                Cliente cliente = _clienteController.ObtenerClientePorId(idCliente);

                if (cliente != null)
                {
                    string detallesCliente = $"Nombre: {cliente.Nombre}\nApellido: {cliente.Apellido}\nDirección: {cliente.Direccion}\nDNI: {cliente.Dni}\nFecha: {cliente.Fecha}";
                    MessageBox.Show(detallesCliente, "Detalles del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente de la lista para ver los detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeerVideo_Click(object sender, EventArgs e)
        {
            if (lstVideos.SelectedIndex != -1)
            {
                int idVideo = lstVideos.SelectedIndex;
                Video video = _videoController.ObtenerVideoPorId(idVideo);

                if (video != null)
                {
                    string detallesVideo = $"Título: {video.Title}\nDirector: {video.Director}\nID Cliente: {video.ClienteId}";
                    MessageBox.Show(detallesVideo, "Detalles del Video", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un video de la lista para ver los detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnActualizarVideo_Click(object sender, EventArgs e)
        {
            if (lstVideos.SelectedIndex != -1)
            {
                int idVideo = lstVideos.SelectedIndex;
                UpdateVideoView updateVideoView = new UpdateVideoView(_videoController, idVideo);
                updateVideoView.ShowDialog();
                ActualizarListaVideos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un video de la lista para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarVideo_Click(object sender, EventArgs e)
        {
            if (lstVideos.SelectedIndex != -1)
            {
                int idVideo = lstVideos.SelectedIndex;
                EliminarVideoView eliminarVideoView = new EliminarVideoView(_videoController, idVideo);
                eliminarVideoView.ShowDialog();
                ActualizarListaVideos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente de la lista para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
