using System.Text.Json;
using System.Text;
using System.Data;

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

                // Cargar seguimientos
                if (root.TryGetProperty("followups", out JsonElement followups))
                {
                    var table = new DataTable();
                    table.Columns.Add("Fecha");
                    table.Columns.Add("Peso");
                    table.Columns.Add("IMC");
                    table.Columns.Add("Grasa");
                    table.Columns.Add("Altura");
                    table.Columns.Add("Observaciones");

                    foreach (var f in followups.EnumerateArray())
                    {
                        string date = f.GetProperty("date").GetString();
                        string weight = f.GetProperty("weight").ToString();
                        string imc = f.TryGetProperty("imc", out var imcVal) ? imcVal.ToString() : "";
                        string fat = f.TryGetProperty("fat", out var fatVal) ? fatVal.ToString() : "";
                        string height = f.TryGetProperty("height", out var h) ? h.ToString() : "";
                        string obs = f.TryGetProperty("observations", out var o) ? o.GetString() : "";

                        table.Rows.Add(date, weight, imc, fat, height, obs);
                    }

                    followupGrid.DataSource = table;
                }
            }
            else
            {
                MessageBox.Show("Error al cargar los datos del usuario.");
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
