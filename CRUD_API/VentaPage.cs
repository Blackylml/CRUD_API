using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUD_API.PageCliente;

namespace CRUD_API
{
    public partial class VentaPage : Form
    {
        private readonly HttpClient _httpClient;
        public VentaPage()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7273/api/Venta/") };
            LoadVentasAsync();
            dtpVenta.Format = DateTimePickerFormat.Custom;
            dtpVenta.CustomFormat = "yyyy-MM-dd";
        }

        private async void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevaVenta = new Venta
                {
                    nombre = tbNombreVenta.Text,
                    cantidad_vendida = Convert.ToInt32(tbCantidadVenta.Text),
                    fecha = dtpVenta.Value.ToString("yyyy-MM-dd"), // Asegúrate de que se envía una cadena de fecha válida
                    precio_unitario = Convert.ToInt32(tbPrecioVenta.Text),
                    status = 1
                };

                var content = new StringContent(JsonConvert.SerializeObject(nuevaVenta), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("agregar", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Venta agregada exitosamente.");
                    await LoadVentasAsync(); // Asegúrate de que se espere a que la carga de datos finalice
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al agregar la venta: {response.StatusCode} - {responseContent}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
            }
        }

        private async void btnModificarVenta_Click(object sender, EventArgs e)
        {
            if (dataGridViewVenta.SelectedRows.Count > 0)
            {
                var idCliente = Convert.ToInt32(dataGridViewVenta.SelectedRows[0].Cells["idVenta"].Value);
                var clienteActualizado = new Venta
                {
                    nombre = tbNombreVenta.Text,
                    cantidad_vendida = int.Parse(tbCantidadVenta.Text),
                    fecha = dtpVenta.Value.ToString("yyyy-MM-dd"),
                    precio_unitario = int.Parse(tbPrecioVenta.Text),
                    status = 1
                };

                var json = JsonConvert.SerializeObject(clienteActualizado);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync($"{idCliente}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cliente modificado exitosamente.");
                    LoadVentasAsync();
                }
                else
                {
                    MessageBox.Show("Error al modificar cliente.");
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewVenta.SelectedRows.Count > 0)
                {
                    var idVenta = Convert.ToInt32(dataGridViewVenta.SelectedRows[0].Cells["idVenta"].Value);
                    var response = await _httpClient.PutAsync($"{idVenta}/eliminar", null);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Venta eliminada exitosamente.");
                        await LoadVentasAsync(); // Asegura que se espere a que la carga de datos finalice
                    }
                    else
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error al eliminar la venta: {response.StatusCode} - {responseContent}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
            }
        }
        private async Task LoadVentasAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("getAll");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var ventas = JsonConvert.DeserializeObject<List<Venta>>(jsonString);

                    // Crear una nueva lista con la columna totalventa calculada
                    var ventasConTotal = ventas.Select(v => new
                    {
                        v.idVenta,
                        v.nombre,
                        v.cantidad_vendida,
                        v.fecha,
                        v.precio_unitario,
                        v.status,
                        totalventa = v.cantidad_vendida * v.precio_unitario
                    }).ToList();

                    dataGridViewVenta.DataSource = ventasConTotal;
                    dataGridViewVenta.Columns["idVenta"].Visible = false;
                    dataGridViewVenta.Columns["status"].Visible = false;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al cargar las ventas: {response.StatusCode} - {responseContent}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            tbNombreVenta.Clear();
            tbCantidadVenta.Clear();
            tbPrecioVenta.Clear();
        }

        private void dataGridViewVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewVenta.Rows[e.RowIndex];

                tbNombreVenta.Text = row.Cells["nombre"].Value.ToString();
                tbCantidadVenta.Text = row.Cells["cantidad_vendida"].Value.ToString();
                dtpVenta.Value = Convert.ToDateTime(row.Cells["fecha"].Value);
                tbPrecioVenta.Text = row.Cells["precio_unitario"].Value.ToString();
            }
        }

        private void tbCantidadVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }
        public class Venta
        {
            public int idVenta { get; set; }
            public string nombre { get; set; }
            public int cantidad_vendida { get; set; }
            public string fecha { get; set; }
            public int precio_unitario { get; set; }
            public int status { get; set; }
        }
    }
}
