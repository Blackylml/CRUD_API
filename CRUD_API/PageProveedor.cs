using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_API
{
    public partial class PageProveedor : Form
    {
        private readonly HttpClient _httpClient;
        public PageProveedor()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7273/api/Proveedor/") };
            LoadProveedoresAsync();
        }

        private async void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            var nuevoProveedor = new Proveedor
            {
                nombre = tbNombreProveedor.Text,
                direccion = tbDireccionProveedor.Text,
                correo_electronico = tbCorreoElectronicoProveedor.Text,
                telefono = tbTelefonoProveedor.Text,
                status = 1
            };

            var json = JsonConvert.SerializeObject(nuevoProveedor);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("agregar", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Proveedor agregado exitosamente.");
                await LoadProveedoresAsync();
            }
            else
            {
                MessageBox.Show("Error al agregar proveedor.");
            }
        }

        private async void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedor.SelectedRows.Count > 0)
            {
                var idProveedor = Convert.ToInt32(dataGridViewProveedor.SelectedRows[0].Cells["idProveedor"].Value);
                var proveedorActualizado = new Proveedor
                {
                    nombre = tbNombreProveedor.Text,
                    direccion = tbDireccionProveedor.Text,
                    correo_electronico = tbCorreoElectronicoProveedor.Text,
                    telefono = tbTelefonoProveedor.Text,
                    status = 1
                };

                var json = JsonConvert.SerializeObject(proveedorActualizado);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync($"{idProveedor}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Proveedor modificado exitosamente.");
                    await LoadProveedoresAsync();
                }
                else
                {
                    MessageBox.Show("Error al modificar proveedor.");
                }
            }
        }

        private async void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedor.SelectedRows.Count > 0)
            {
                var idProveedor = Convert.ToInt32(dataGridViewProveedor.SelectedRows[0].Cells["idProveedor"].Value);
                var response = await _httpClient.PutAsync($"{idProveedor}/eliminar", null);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Proveedor eliminado exitosamente.");
                    await LoadProveedoresAsync();
                }
                else
                {
                    MessageBox.Show("Error al eliminar proveedor.");
                }
            }
        }
        private async Task LoadProveedoresAsync()
        {
            var response = await _httpClient.GetAsync("getAll");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var proveedores = JsonConvert.DeserializeObject<List<Proveedor>>(jsonString);
                dataGridViewProveedor.DataSource = proveedores;

                // Ocultar columnas no deseadas
                if (dataGridViewProveedor.Columns["idProveedor"] != null)
                {
                    dataGridViewProveedor.Columns["idProveedor"].Visible = false;
                }

                if (dataGridViewProveedor.Columns["status"] != null)
                {
                    dataGridViewProveedor.Columns["status"].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Error al cargar proveedores.");
            }
        }



        private void dataGridViewProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProveedor.Rows[e.RowIndex];
                tbNombreProveedor.Text = row.Cells["nombre"].Value.ToString();
                tbDireccionProveedor.Text = row.Cells["direccion"].Value.ToString();
                tbCorreoElectronicoProveedor.Text = row.Cells["correo_electronico"].Value.ToString();
                tbTelefonoProveedor.Text = row.Cells["telefono"].Value.ToString();
            }
        }

        private void tbCorreoElectronicoProveedor_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(tbCorreoElectronicoProveedor.Text, pattern))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void tbTelefonoProveedor_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            tbNombreProveedor.Clear();
            tbDireccionProveedor.Clear();
            tbCorreoElectronicoProveedor.Clear();
            tbTelefonoProveedor.Clear();
        }

        private void tbTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegresarProveedor_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
        }

        public class Proveedor
        {
            public int idProveedor { get; set; }
            public string nombre { get; set; }
            public string direccion { get; set; }
            public string correo_electronico { get; set; }
            public string telefono { get; set; }
            public int status { get; set; }
        }
     }


}
