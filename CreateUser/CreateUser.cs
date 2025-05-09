using System.Text.Json;
using System.Text;

namespace CreateUser
{
    public partial class CreateUser : Form
    {
        private readonly HttpClient client;
        public CreateUser()
        {
            InitializeComponent();
            client = new HttpClient
            {
                BaseAddress = new Uri("http://127.0.0.1:8000/")
            };
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            bool isClient = chkClient.Checked;
            bool isAdmin = chkAdmin.Checked;
            string? endSub = dtpEndSub.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var payload = new
            {
                fullname = name,
                email = email,
                password = password,
                client = isClient,
                admin = isAdmin,
                end_sub = endSub
            };

            string json = JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync("api/users/create/", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al crear el usuario:\n{errorResponse}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}