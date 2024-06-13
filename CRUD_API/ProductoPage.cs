using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_API
{
    public partial class ProductoPage : Form
    {
        private readonly HttpClient _httpClient;
        public ProductoPage()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7273/api/Producto/") };
            LoadProductosAsync();
            dataGridViewProducto.CellClick += dataGridViewProducto_CellClick;
        }

        private void ProductoPage_Load(object sender, EventArgs e)
        {

        }

        private async void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoProducto = new Producto
                {
                    nombre = tbNombreProducto.Text,
                    precio = Convert.ToInt32(tbPrecioProducto.Text),
                    cantidad = Convert.ToInt32(tbCantidadProducto.Text),
                    status = 1
                };

                var content = new StringContent(JsonConvert.SerializeObject(nuevoProducto), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("agregar", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto agregado exitosamente.");
                    await LoadProductosAsync();
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al agregar el producto: {response.StatusCode} - {responseContent}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
            }
        }

        private async void btnModificarProcuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProducto.SelectedRows.Count > 0)
                {
                    var idProducto = Convert.ToInt32(dataGridViewProducto.SelectedRows[0].Cells["idProducto"].Value);
                    var productoActualizado = new Producto
                    {
                        nombre = tbNombreProducto.Text,
                        precio = Convert.ToInt32(tbPrecioProducto.Text),
                        cantidad = Convert.ToInt32(tbCantidadProducto.Text),
                        status = 1
                    };

                    var content = new StringContent(JsonConvert.SerializeObject(productoActualizado), Encoding.UTF8, "application/json");
                    var response = await _httpClient.PutAsync($"{idProducto}", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto modificado exitosamente.");
                        await LoadProductosAsync();
                    }
                    else
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al modificar el producto: {response.StatusCode} - {responseContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
            }
        }

        private async void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProducto.SelectedRows.Count > 0)
                {
                    var idProducto = Convert.ToInt32(dataGridViewProducto.SelectedRows[0].Cells["idProducto"].Value);
                    var response = await _httpClient.PutAsync($"{idProducto}/eliminar", null);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto eliminado exitosamente.");
                        await LoadProductosAsync();
                    }
                    else
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al eliminar el producto: {response.StatusCode} - {responseContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
            }
        }
        private async Task LoadProductosAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("getAll");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var productos = JsonConvert.DeserializeObject<List<Producto>>(jsonString);
                    dataGridViewProducto.DataSource = productos;

                    // Ocultar columnas no deseadas
                    if (dataGridViewProducto.Columns["idProducto"] != null)
                    {
                        dataGridViewProducto.Columns["idProducto"].Visible = false;
                    }

                    if (dataGridViewProducto.Columns["status"] != null)
                    {
                        dataGridViewProducto.Columns["status"].Visible = false;
                    }
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al cargar los productos: {response.StatusCode} - {responseContent}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
            }
        }

        public class Producto
        {
            public int idProducto { get; set; }
            public string nombre { get; set; }
            public int precio { get; set; }
            public int cantidad { get; set; }
            public int status { get; set; }
        }
        private void dataGridViewProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProducto.Rows[e.RowIndex];
                tbNombreProducto.Text = row.Cells["nombre"].Value.ToString();
                tbPrecioProducto.Text = row.Cells["precio"].Value.ToString();
                tbCantidadProducto.Text = row.Cells["cantidad"].Value.ToString();
            }
        }


        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            tbNombreProducto.Clear();
            tbPrecioProducto.Clear();
            tbCantidadProducto.Clear();
        }

        private void tbPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCantidadProducto_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void tbCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
