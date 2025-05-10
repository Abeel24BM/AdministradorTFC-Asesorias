using System.Text;
using System.Text.Json;
using System.Xml.Linq;

namespace DetailsFood
{
    public partial class DetailsFood : Form
    {
        private readonly HttpClient client;
        private readonly int foodId;
        public DetailsFood()
        {
            InitializeComponent();
        }
        public DetailsFood(HttpClient httpClient, int foodId)
        {
            InitializeComponent();
            this.foodId = foodId;
            client = httpClient;
            this.Load += DetailsFood_Load;
        }

        private async void DetailsFood_Load(object sender, EventArgs e)
        {
            try
            {
                var resp = await client.GetAsync($"api/foods/{foodId}/");
                resp.EnsureSuccessStatusCode();
                string raw = await resp.Content.ReadAsStringAsync();
                var json = JsonDocument.Parse(raw).RootElement;

                txtNombre.Text = json.GetProperty("name").GetString();
                cmbTipo.SelectedItem = json.GetProperty("food").GetString();
                txtCantidad.Text = json.GetProperty("cuantity").GetString();
                txtCalorias.Text = json.GetProperty("calories").GetString();
                txtProteina.Text = json.GetProperty("protein_g").GetString();
                txtGrasa.Text = json.GetProperty("fat_total_g").GetString();
                txtCarbohidratos.Text = json.GetProperty("carbohydrates_total_g").GetString();
                dtpFecha.Value = DateTime.Parse(json.GetProperty("date").GetString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
                Close();
            }
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new
                {
                    name = txtNombre.Text.Trim(),
                    food = cmbTipo.SelectedItem?.ToString() ?? "",
                    cuantity = decimal.Parse(txtCantidad.Text),
                    calories = decimal.Parse(txtCalorias.Text),
                    protein_g = decimal.Parse(txtProteina.Text),
                    fat_total_g = decimal.Parse(txtGrasa.Text),
                    carbohydrates_total_g = decimal.Parse(txtCarbohidratos.Text),
                    date = dtpFecha.Value.ToString("yyyy-MM-dd")
                };

                var json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var resp = await client.PutAsync($"api/foods/{foodId}/", content);

                if (resp.IsSuccessStatusCode)
                {
                    MessageBox.Show("Comida actualizada correctamente.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    string err = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al actualizar: " + err);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
    }
}
