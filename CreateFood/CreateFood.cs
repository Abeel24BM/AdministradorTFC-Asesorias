using System.Text.Json;
using System.Text;

namespace CreateFood
{
    public partial class CreateFood : Form
    {
        private readonly int userId;
        private readonly HttpClient client;
        private List<Dictionary<string, object>> resultadosBuscados = new();
        private decimal baseCalories = 0;
        private decimal baseProtein = 0;
        private decimal baseFat = 0;
        private decimal baseCarbs = 0;


        public CreateFood()
        {
            InitializeComponent();
            client = new HttpClient
            {
                BaseAddress = new Uri("http://127.0.0.1:8000/")
            };
        }

        public CreateFood(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            client = new HttpClient
            {
                BaseAddress = new Uri("http://127.0.0.1:8000/")
            };
        }
        private void CreateFood_Load(object sender, EventArgs e)
        {
            txtQuantity.TextChanged += TxtQuantity_TextChanged;
            lstResultados.SelectedIndexChanged += LstResultados_SelectedIndexChanged;
            cmbTipo.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Today;
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Introduce un término de búsqueda.");
                return;
            }

            try
            {
                var data = new Dictionary<string, string> { { "query", query } };
                var content = new FormUrlEncodedContent(data);
                content.Headers.Add("X-Requested-With", "XMLHttpRequest");

                var resp = await client.PostAsync("api/food_search/", content);
                resp.EnsureSuccessStatusCode();

                string raw = await resp.Content.ReadAsStringAsync();
                var doc = JsonDocument.Parse(raw).RootElement;

                resultadosBuscados.Clear();
                lstResultados.Items.Clear();

                foreach (var item in doc.GetProperty("results").EnumerateArray())
                {
                    var foodDict = new Dictionary<string, object>
            {
                { "name", item.GetProperty("name").GetString() ?? "" },
                { "calories", item.TryGetProperty("calories", out var c) ? c.GetDecimal() : 0 },
                { "protein_g", item.TryGetProperty("protein_g", out var p) ? p.GetDecimal() : 0 },
                { "fat_total_g", item.TryGetProperty("fat_total_g", out var f) ? f.GetDecimal() : 0 },
                { "carbohydrates_total_g", item.TryGetProperty("carbohydrates_total_g", out var ch) ? ch.GetDecimal() : 0 }
            };

                    resultadosBuscados.Add(foodDict);
                    lstResultados.Items.Add(foodDict["name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar alimento: " + ex.Message);
            }
        }

        private void LstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstResultados.SelectedIndex == -1) return;

            var food = resultadosBuscados[lstResultados.SelectedIndex];

            txtName.Text = food["name"].ToString();

            baseCalories = Convert.ToDecimal(food["calories"]);
            baseProtein = Convert.ToDecimal(food["protein_g"]);
            baseFat = Convert.ToDecimal(food["fat_total_g"]);
            baseCarbs = Convert.ToDecimal(food["carbohydrates_total_g"]);
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                txtQuantity.Text = "100";

            UpdateMacrosForQuantity(); 
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            UpdateMacrosForQuantity();
        }

        private void UpdateMacrosForQuantity()
        {
            if (!decimal.TryParse(txtQuantity.Text, out decimal cantidad) || cantidad <= 0)
                return;

            decimal factor = cantidad / 100m;

            txtCalories.Text = (baseCalories * factor).ToString("0.##");
            txtProtein.Text = (baseProtein * factor).ToString("0.##");
            txtFat.Text = (baseFat * factor).ToString("0.##");
            txtCarbs.Text = (baseCarbs * factor).ToString("0.##");
        }



        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var payload = new
                {
                    user = userId,
                    name = txtName.Text.Trim(),
                    calories = decimal.Parse(txtCalories.Text),
                    protein_g = decimal.Parse(txtProtein.Text),
                    fat_total_g = decimal.Parse(txtFat.Text),
                    carbohydrates_total_g = decimal.Parse(txtCarbs.Text),
                    cuantity = decimal.Parse(txtQuantity.Text),
                    food = cmbTipo.SelectedItem.ToString(),
                    date = dtpFecha.Value.ToString("yyyy-MM-dd")
                };

                var json = JsonSerializer.Serialize(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var resp = await client.PostAsync("api/foods/create/", content);
                if (resp.IsSuccessStatusCode)
                {
                    MessageBox.Show("Comida guardada correctamente.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    var error = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al guardar: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos inválidos o error de conexión: " + ex.Message);
            }
        }
    }
}
