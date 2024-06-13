using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_API
{
    public partial class PageCompra : Form
    {
        private readonly HttpClient _httpClient;
        public PageCompra()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7273/api/Compra/") };
            LoadComprasAsync();
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "yyyy-MM-dd";
        }

        private async void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevaCompra = new Compra
                {
                    nombre = tbNombre.Text,
                    cantidad_comprada = Convert.ToInt32(tbCantidadComprada.Text),
                    fecha = dtpFecha.Value.ToString("yyyy-MM-dd"), // Asegúrate de que se envía una cadena de fecha válida
                    precio_unitario = Convert.ToInt32(tbPrecioUnitario.Text),
                    status = 1
                };

                var content = new StringContent(JsonConvert.SerializeObject(nuevaCompra), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("agregar", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Compra agregada exitosamente.");
                    await LoadComprasAsync(); // Asegúrate de que se espere a que la carga de datos finalice
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al agregar la compra: {response.StatusCode} - {responseContent}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
            }
        }

        private async void btnModificarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCompra.SelectedRows.Count > 0)
                {
                    var idCompra = Convert.ToInt32(dataGridViewCompra.SelectedRows[0].Cells["idCompra"].Value);
                    var compraActualizada = new Compra
                    {
                        nombre = tbNombre.Text,
                        cantidad_comprada = Convert.ToInt32(tbCantidadComprada.Text),
                        fecha = dtpFecha.Value.ToString("yyyy-MM-dd"),
                        precio_unitario = Convert.ToInt32(tbPrecioUnitario.Text),
                        status = 1
                    };

                    var content = new StringContent(JsonConvert.SerializeObject(compraActualizada), Encoding.UTF8, "application/json");
                    var response = await _httpClient.PutAsync($"{idCompra}", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Compra modificada exitosamente.");
                        await LoadComprasAsync(); // Asegúrate de que se espere a que la carga de datos finalice
                    }
                    else
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al modificar la compra: {response.StatusCode} - {responseContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
            }
        }

        private async void btnEliminarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCompra.SelectedRows.Count > 0)
                {
                    var idCompra = Convert.ToInt32(dataGridViewCompra.SelectedRows[0].Cells["idCompra"].Value);
                    var response = await _httpClient.PutAsync($"{idCompra}/eliminar", null);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Compra eliminada exitosamente.");
                        await LoadComprasAsync(); // Asegura que se espere a que la carga de datos finalice
                    }
                    else
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al eliminar la compra: {response.StatusCode} - {responseContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
            }
        }
        private async Task LoadComprasAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("getAll");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var compras = JsonConvert.DeserializeObject<List<Compra>>(jsonString);

                    // Crear una nueva lista con la columna totalcompra calculada
                    var comprasConTotal = compras.Select(c => new
                    {
                        c.idCompra,
                        c.nombre,
                        c.cantidad_comprada,
                        c.fecha,
                        c.precio_unitario,
                        c.status,
                        totalcompra = c.cantidad_comprada * c.precio_unitario
                    }).ToList();

                    dataGridViewCompra.DataSource = comprasConTotal;

                    //// Ocultar columnas no deseadas
                    //if (dataGridViewCompra.Columns["idCompra"] != null)
                    //{
                    //    dataGridViewCompra.Columns["idCompra"].Visible = false;
                    //}

                    //if (dataGridViewCompra.Columns["status"] != null)
                    //{
                    //    dataGridViewCompra.Columns["status"].Visible = false;
                    //}
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al cargar las compras: {response.StatusCode} - {responseContent}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
            }
        }

        private void dataGridViewCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCompra.Rows[e.RowIndex];
                tbNombre.Text = row.Cells["nombre"].Value.ToString();
                tbCantidadComprada.Text = row.Cells["cantidad_comprada"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(row.Cells["fecha"].Value);
                tbPrecioUnitario.Text = row.Cells["precio_unitario"].Value.ToString();
            }
        }

        private void tbCantidadComprada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnLimpiarCompra_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbCantidadComprada.Clear();
            tbPrecioUnitario.Clear();
        }

        private void btnRegresarCompra_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
        }
        public class Compra
        {
            public int idCompra { get; set; }
            public string nombre { get; set; }
            public int cantidad_comprada { get; set; }
            public string fecha { get; set; }
            public int precio_unitario { get; set; } 
            public int status { get; set; }
        }
    }
}
