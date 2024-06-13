using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks; // Necesario para el tipo Task
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CRUD_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            string correoElectronico = tbUsuarioLogin.Text;
            string password = tbContraseñaLogin.Text;

            var loginRequest = new
            {
                CorreoElectronico = correoElectronico,
                Password = password
            };

            string json = JsonConvert.SerializeObject(loginRequest);

            using (var client = new HttpClient())
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7273/api/Usuario/login", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Aquí puedes manejar la respuesta y redirigir al usuario a otra ventana, por ejemplo:
                    MessageBox.Show("Login successful!");
                    // Redirigir a otra ventana
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();
                }
                else
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Login failed: {response.StatusCode} - {responseBody}");
                }

            }

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }
    }
}



