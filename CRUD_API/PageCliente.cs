using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CRUD_API
{
    public partial class PageCliente : Form
    {
        private readonly HttpClient _httpClient;
        public PageCliente()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7273/api/Cliente/") };
            LoadClientesAsync();
        }

        private async void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new Cliente
            {
                nombre = tbNombre.Text,
                direccion = tbDireccion.Text,
                correo_electronico = tbCorreoElectronico.Text,
                telefono = tbTelefono.Text,
                status = 1
            };

            var json = JsonConvert.SerializeObject(nuevoCliente);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("agregar", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cliente agregado exitosamente.");
                LoadClientesAsync();
            }
            else
            {
                MessageBox.Show("Error al agregar cliente.");
            }
        }

        private async void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count > 0)
            {
                var idCliente = Convert.ToInt32(dataGridViewCliente.SelectedRows[0].Cells["idCliente"].Value);
                var clienteActualizado = new Cliente
                {
                    nombre = tbNombre.Text,
                    direccion = tbDireccion.Text,
                    correo_electronico = tbCorreoElectronico.Text,
                    telefono = tbTelefono.Text,
                    status = 1
                };

                var json = JsonConvert.SerializeObject(clienteActualizado);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync($"{idCliente}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente modificado exitosamente.");
                    LoadClientesAsync();
                }
                else
                {
                    MessageBox.Show("Error al modificar cliente.");
                }
            }
        }

        private async void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count > 0)
            {
                var idCliente = Convert.ToInt32(dataGridViewCliente.SelectedRows[0].Cells["idCliente"].Value);
                var response = await _httpClient.PutAsync($"{idCliente}/eliminar", null);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente eliminado exitosamente.");
                    LoadClientesAsync();
                }
                else
                {
                    MessageBox.Show("Error al eliminar cliente.");
                }
            }
        }

        private void btnRegresarCliente_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
        }
        public class Cliente
        {
            public int idCliente { get; set; }
            public string nombre { get; set; }
            public string direccion { get; set; }
            public string correo_electronico { get; set; }
            public string telefono { get; set; }
            public int status { get; set; }
        }

        private async void PageCliente_Load(object sender, EventArgs e)
        {

        }
        private async Task LoadClientesAsync()
        {
            var response = await _httpClient.GetAsync("getAll");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var clientes = JsonConvert.DeserializeObject<List<Cliente>>(jsonString);
                dataGridViewCliente.DataSource = clientes;

                // Ocultar columnas no deseadas
                if (dataGridViewCliente.Columns["idCliente"] != null)
                {
                    dataGridViewCliente.Columns["idCliente"].Visible = false;
                }

                if (dataGridViewCliente.Columns["status"] != null)
                {
                    dataGridViewCliente.Columns["status"].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Error al cargar clientes.");
            }
        }


        private void dataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCliente.Rows[e.RowIndex];
                tbNombre.Text = row.Cells["nombre"].Value.ToString();
                tbDireccion.Text = row.Cells["direccion"].Value.ToString();
                tbCorreoElectronico.Text = row.Cells["correo_electronico"].Value.ToString();
                tbTelefono.Text = row.Cells["telefono"].Value.ToString();
            }
        }

        private void tbCorreoElectronico_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Define la expresión regular para validar el correo electrónico
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Verifica si el correo electrónico coincide con el patrón
            if (!Regex.IsMatch(tbCorreoElectronico.Text, pattern))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbDireccion.Clear();
            tbCorreoElectronico.Clear();
            tbTelefono.Clear();
        }
    }
}
