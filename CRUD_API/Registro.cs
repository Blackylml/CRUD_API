using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_API
{
    public partial class Registro : Form
    {
        private readonly HttpClient _httpClient;
        public Registro()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7273/api/") };
        }

        private async void btnRegistro_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string correo = tbCorreo.Text;
            string contraseña = tbContraseña.Text;
            string confirmarContraseña = tbContraseñaConfirmar.Text;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
                return;
            }

            if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            if (contraseña != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            var registroRequest = new RegisterRequest
            {
                Nombre = nombre,
                CorreoElectronico = correo,
                Password = contraseña
            };

            var content = new StringContent(JsonConvert.SerializeObject(registroRequest), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("Usuario/register", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Registro exitoso.");
                // Navegar de regreso al formulario de inicio de sesión
                this.Hide();
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
            else
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Error al registrar: {response.StatusCode} - {responseContent}");
            }
        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void tbCorreo_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                tbCorreo.Focus();
            }
        }

        private void tbContraseñaConfirmar_Leave(object sender, EventArgs e)
        {

            if (tbContraseña.Text != tbContraseñaConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                tbContraseñaConfirmar.Focus();
            }

        }
        public class RegisterRequest
        {
            public string Nombre { get; set; }
            public string CorreoElectronico { get; set; }
            public string Password { get; set; }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            tbNombre.Focus();
        }
    }
}
