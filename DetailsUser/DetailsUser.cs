using System.Text.Json;
using System.Text;

namespace DetailsUser
{
    public partial class DetailsUser : Form
    {
        private int _idUsuario;
        private readonly HttpClient client;
        public DetailsUser()
        {
            InitializeComponent();
        }

        public DetailsUser(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            client = new HttpClient
            {
                BaseAddress = new Uri("http://127.0.0.1:8000/")
            };
        }

        private async void DetailsUser_Load(object sender, EventArgs e)
        {

            {
                var response = await client.GetAsync($"api/users/{_idUsuario}/");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    using JsonDocument doc = JsonDocument.Parse(json);
                    JsonElement root = doc.RootElement;

                    txtFullName.Text = root.GetProperty("fullname").GetString();
                    txtEmail.Text = root.GetProperty("email").GetString();
                    txtPassword.Text = root.GetProperty("password").GetString();
                    chkClient.Checked = root.GetProperty("client").GetBoolean();
                    chkAdmin.Checked = root.GetProperty("admin").GetBoolean();

                    if (root.TryGetProperty("end_sub", out JsonElement endSub) && endSub.ValueKind != JsonValueKind.Null)
                    {
                        dtpEndSub.Value = DateTime.Parse(endSub.GetString());
                    }
                }
                else
                {
                    MessageBox.Show("Error al cargar los datos del usuario.");
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var updatedUser = new
            {
                fullname = txtFullName.Text,
                email = txtEmail.Text,
                password = txtPassword.Text,
                client = chkClient.Checked,
                admin = chkAdmin.Checked,
                end_sub = dtpEndSub.Value.ToString("yyyy-MM-dd")
            };

            string json = JsonSerializer.Serialize(updatedUser);

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"api/users/{_idUsuario}/", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Usuario actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al actualizar el usuario.");
            }
        }
    }
}
