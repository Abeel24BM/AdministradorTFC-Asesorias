using System.Text;
using System.Text.Json;

namespace DetailsExercise
{
    public partial class DetailsExercise : Form
    {
        private readonly int exerciseId;
        private readonly HttpClient client;

        public DetailsExercise()
        {
            InitializeComponent();
        }
        public DetailsExercise(int exerciseId)
        {
            InitializeComponent();
            this.exerciseId = exerciseId;
            client = new HttpClient
            {
                BaseAddress = new Uri("http://127.0.0.1:8000/")
            };
        }


        private void TxtVideoUrl_Leave(object? sender, EventArgs e)
        {
            string url = txtVideoUrl.Text.Trim();
            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    videoBrowser.Navigate(url);
                }
                catch
                {
                    MessageBox.Show("URL de video no válida.");
                }
            }
        }

        private async void BtnSave_Click(object? sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            string recommendations = txtRecommendations.Text.Trim();
            string video = txtVideoUrl.Text.Trim();
            string muscle = cmbMuscleGroup.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(muscle))
            {
                MessageBox.Show("Por favor, completa los campos obligatorios (nombre y músculo).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            string json = JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var resp = await client.PutAsync($"api/exercises/{exerciseId}/", content);
                if (resp.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ejercicio actualizado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    string errorMsg = await resp.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al guardar:\n" + errorMsg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }


        private async void DetailsExercise_Load(object sender, EventArgs e)
        {
            cmbMuscleGroup.Items.Clear();

            try
            {
                var muscleResp = await client.GetAsync("api/muscles/");
                muscleResp.EnsureSuccessStatusCode();

                string muscleJson = await muscleResp.Content.ReadAsStringAsync();
                var muscleDoc = JsonDocument.Parse(muscleJson).RootElement;

                if (muscleDoc.TryGetProperty("muscles", out var muscles))
                {
                    foreach (var m in muscles.EnumerateArray())
                    {
                        cmbMuscleGroup.Items.Add(m.GetString());
                    }
                }

                var resp = await client.GetAsync($"api/exercises/{exerciseId}/");
                resp.EnsureSuccessStatusCode();

                string json = await resp.Content.ReadAsStringAsync();
                var doc = JsonDocument.Parse(json).RootElement;

                txtName.Text = doc.GetProperty("name").GetString();
                txtDescription.Text = doc.GetProperty("description").GetString();
                txtRecommendations.Text = doc.GetProperty("recommendations").GetString();
                txtVideoUrl.Text = doc.GetProperty("video").GetString();

                string muscleName = doc.GetProperty("muscle").GetString() ?? "";

                int idx = cmbMuscleGroup.Items.IndexOf(muscleName);
                if (idx != -1)
                    cmbMuscleGroup.SelectedIndex = idx;

                TxtVideoUrl_Leave(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el ejercicio o los músculos: " + ex.Message);
                this.Close();
            }
        }



    }
}
