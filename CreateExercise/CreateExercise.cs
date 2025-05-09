using System.Text.Json;
using System.Text;

namespace CreateExercise
{
    public partial class CreateExercise : Form
    {
        private readonly HttpClient client;

        public CreateExercise()
        {
            InitializeComponent();
            client = new HttpClient
            {
                BaseAddress = new Uri("http://127.0.0.1:8000/")
            };
        }

        private async void CreateExercise_Load(object sender, EventArgs e)
        {
            cmbMuscleGroup.Items.Clear();

            try
            {
                var resp = await client.GetAsync("api/muscles/");
                resp.EnsureSuccessStatusCode();
                string json = await resp.Content.ReadAsStringAsync();
                var doc = JsonDocument.Parse(json).RootElement;

                if (doc.TryGetProperty("muscles", out var muscles))
                {
                    foreach (var m in muscles.EnumerateArray())
                        cmbMuscleGroup.Items.Add(m.GetString());

                    if (cmbMuscleGroup.Items.Count > 0)
                        cmbMuscleGroup.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar músculos: " + ex.Message);
            }
        }

        private void TxtVideoUrl_Leave(object? sender, EventArgs e)
        {
            string url = txtVideoUrl.Text.Trim();
            if (!string.IsNullOrEmpty(url))
                videoBrowser.Navigate(url);
        }

        private async void BtnCreate_Click(object? sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            string recommendations = txtRecommendations.Text.Trim();
            string video = txtVideoUrl.Text.Trim();
            string muscle = cmbMuscleGroup.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(muscle))
            {
                MessageBox.Show("Nombre y músculo son obligatorios.");
                return;
            }

            var payload = new
            {
                name,
                description,
                recommendations,
                video,
                muscle
            };

            var json = JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync("api/exercises/create/", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ejercicio creado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    string err = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al crear:\n" + err);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
    }
}
