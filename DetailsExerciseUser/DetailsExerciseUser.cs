using System.Text.Json;
using System.Text;

namespace DetailsExerciseUser
{
    public partial class DetailsExerciseUser : Form
    {
        public DetailsExerciseUser()
        {
            InitializeComponent();
        }

        private readonly int exerciseClientId;
        private readonly HttpClient client = new HttpClient { BaseAddress = new Uri("http://127.0.0.1:8000/") };

        public DetailsExerciseUser(int exerciseClientId)
        {
            this.exerciseClientId = exerciseClientId;
            InitializeComponent();
        }

        private async void DetailsExerciseUser_Load(object sender, EventArgs e)
        {
            try
            {
                var respEx = await client.GetAsync("api/exercises/");
                respEx.EnsureSuccessStatusCode();

                var jsonEx = await respEx.Content.ReadAsStringAsync();
                var docEx = JsonDocument.Parse(jsonEx).RootElement;

                var list = new List<KeyValuePair<int, string>>();
                if (docEx.TryGetProperty("exercises", out var exercises))
                {
                    foreach (var ex in exercises.EnumerateArray())
                    {
                        list.Add(new KeyValuePair<int, string>(
                            ex.GetProperty("id").GetInt32(),
                            ex.GetProperty("name").GetString()
                        ));
                    }
                }

                comboExercises.DataSource = new BindingSource(list, null);
                comboExercises.DisplayMember = "Value";
                comboExercises.ValueMember = "Key";

                // Cargar datos del ejercicio asignado
                var resp = await client.GetAsync($"api/exercise_clients/{exerciseClientId}/");
                resp.EnsureSuccessStatusCode();

                var json = await resp.Content.ReadAsStringAsync();
                var doc = JsonDocument.Parse(json).RootElement;

                comboExercises.SelectedValue = doc.GetProperty("exercise").GetInt32();
                numPeso.Value = doc.GetProperty("weight").GetInt32();
                numReps.Value = doc.GetProperty("reps").GetInt32();
                numSets.Value = doc.GetProperty("sets").GetInt32();
                numRest.Value = doc.GetProperty("rest").GetInt32();
                datePicker.Value = DateTime.Parse(doc.GetProperty("date").GetString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboExercises.SelectedItem is not KeyValuePair<int, string> selectedExercise)
            {
                MessageBox.Show("Selecciona un ejercicio.");
                return;
            }

            var payload = new
            {
                exercise = selectedExercise.Key,
                weight = (int)numPeso.Value,
                reps = (int)numReps.Value,
                sets = (int)numSets.Value,
                rest = (int)numRest.Value,
                date = datePicker.Value.ToString("yyyy-MM-dd")
            };

            try
            {
                var json = JsonSerializer.Serialize(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var resp = await client.PutAsync($"api/exercise_clients/{exerciseClientId}/", content);
                resp.EnsureSuccessStatusCode();

                MessageBox.Show("Ejercicio actualizado correctamente.");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message);
            }
        }
    }
}
