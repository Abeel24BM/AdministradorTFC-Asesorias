using System.Text.Json;
using System.Text;

namespace CreateExerciseUser
{
    public partial class CreateExerciseUser : Form
    {
        public CreateExerciseUser()
        {
            InitializeComponent();
        }

        private readonly HttpClient client = new HttpClient { BaseAddress = new Uri("http://127.0.0.1:8000/") };
        private readonly int userId;

        public CreateExerciseUser(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private async void CreateExerciseUser_Load(object sender, EventArgs e)
        {
            try
            {
                var resp = await client.GetAsync("api/exercises/");
                resp.EnsureSuccessStatusCode();

                string json = await resp.Content.ReadAsStringAsync();
                var doc = JsonDocument.Parse(json).RootElement;

                if (doc.TryGetProperty("exercises", out var exercises))
                {
                    var list = new List<KeyValuePair<int, string>>();
                    foreach (var ex in exercises.EnumerateArray())
                    {
                        int id = ex.GetProperty("id").GetInt32();
                        string name = ex.GetProperty("name").GetString();
                        list.Add(new KeyValuePair<int, string>(id, name));
                    }
                    comboExercises.DataSource = new BindingSource(list, null);
                    comboExercises.DisplayMember = "Value";
                    comboExercises.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ejercicios: " + ex.Message);
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
                user = userId,
                exercise = selectedExercise.Key,
                weight = (int)numPeso.Value,
                reps = (int)numReps.Value,
                sets = (int)numSets.Value,
                rest = (int)numRest.Value,
                date = datePicker.Value.ToString("yyyy-MM-dd")
            };

            try
            {
                string json = JsonSerializer.Serialize(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var resp = await client.PostAsync("api/exercise_clients/", content);
                resp.EnsureSuccessStatusCode();

                MessageBox.Show("Ejercicio asignado correctamente.");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar ejercicio: " + ex.Message);
            }
        }
    }
}
