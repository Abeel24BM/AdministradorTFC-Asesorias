using System.Data;
using System.Text.Json;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;
using DetailsUser;
using CreateUser;
using DetailsExercise;
using CreateExercise;
using CreateFood;
using DetailsFood;

namespace AdministradorTFC
{
    public partial class Administrador : Form
    {

        private readonly HttpClient client;
        private readonly DataTable usersTable = new DataTable();
        private readonly DataTable exercisesTable = new DataTable();
        public Administrador()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Load += (s, e) =>
            {
                groupLogin.Left = (this.ClientSize.Width - groupLogin.Width) / 2;
                groupLogin.Top = (this.ClientSize.Height - groupLogin.Height) / 2;
                groupLogin.BringToFront();
            };
            this.Resize += (s, e) =>
            {
                groupLogin.Left = (this.ClientSize.Width - groupLogin.Width) / 2;
                groupLogin.Top = (this.ClientSize.Height - groupLogin.Height) / 2;
            };


            // Configurar grids
            userGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userGrid.MultiSelect = false;

            exerciseGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            exerciseGrid.MultiSelect = false;

            // Inicializar HttpClient
            client = new HttpClient
            {
                BaseAddress = new Uri("http://127.0.0.1:8000/")
            };

            // Mostrar solo login al inicio
            groupLogin.Visible = true;
            groupAdministrador.Visible = false;
            groupEjercicios.Visible = false;
            groupComidas.Visible = false;

        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string userEmail = email.Text.Trim();
            string userPassword = password.Text;

            if (string.IsNullOrWhiteSpace(userEmail) || string.IsNullOrWhiteSpace(userPassword))
            {
                MessageBox.Show("Por favor, rellena todos los campos.");
                return;
            }

            var payload = new { email = userEmail, password = userPassword };
            string json = JsonSerializer.Serialize(payload);

            using var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var resp = await client.PostAsync("login_admin/", content);
                resp.EnsureSuccessStatusCode();

                string raw = await resp.Content.ReadAsStringAsync();
                using var doc = JsonDocument.Parse(raw);
                var root = doc.RootElement;

                if (root.GetProperty("success").GetBoolean())
                {
                    // Mostrar interfaz de administración
                    groupLogin.Visible = false;
                    groupAdministrador.Visible = true;
                    groupEjercicios.Visible = true;
                    groupComidas.Visible = true;

                    // Cargar datos
                    await LoadUsersAsync();
                    await LoadExercisesAsync();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas.");
                    email.Clear();
                    password.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private async Task LoadUsersAsync()
        {
            // Preparar DataTable
            usersTable.Clear();
            usersTable.Columns.Clear();
            usersTable.Columns.Add("id", typeof(int));
            usersTable.Columns.Add("fullname", typeof(string));
            usersTable.Columns.Add("email", typeof(string));
            usersTable.Columns.Add("end_sub", typeof(string));

            var resp = await client.GetAsync("api/users/");
            resp.EnsureSuccessStatusCode();

            string raw = await resp.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(raw);

            if (doc.RootElement.TryGetProperty("users", out JsonElement usersElem))
            {
                foreach (var u in usersElem.EnumerateArray())
                {
                    int id = u.GetProperty("id").GetInt32();
                    string fullname = u.GetProperty("fullname").GetString();
                    string mail = u.GetProperty("email").GetString();
                    string endSub = u.TryGetProperty("end_sub", out var es) && es.ValueKind != JsonValueKind.Null
                                      ? es.GetDateTime().ToString("yyyy-MM-dd")
                                      : "";
                    usersTable.Rows.Add(id, fullname, mail, endSub);
                }

                userGrid.DataSource = usersTable;
            }
            else
            {
                MessageBox.Show("Respuesta inesperada: falta 'users'.");
            }
        }

        private async Task LoadExercisesAsync()
        {
            exercisesTable.Clear();
            exercisesTable.Columns.Clear();
            exercisesTable.Columns.Add("id", typeof(int));
            exercisesTable.Columns.Add("name", typeof(string));
            exercisesTable.Columns.Add("description", typeof(string));
            exercisesTable.Columns.Add("video", typeof(string));
            exercisesTable.Columns.Add("recommendations", typeof(string));
            exercisesTable.Columns.Add("muscle", typeof(string));

            var resp = await client.GetAsync("api/exercises/");
            resp.EnsureSuccessStatusCode();

            string raw = await resp.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(raw);

            if (doc.RootElement.TryGetProperty("exercises", out JsonElement exElem))
            {
                foreach (var e in exElem.EnumerateArray())
                {
                    exercisesTable.Rows.Add(
                        e.GetProperty("id").GetInt32(),
                        e.GetProperty("name").GetString(),
                        e.GetProperty("description").GetString(),
                        e.GetProperty("video").GetString(),
                        e.GetProperty("recommendations").GetString(),
                        e.GetProperty("muscle").GetString()
                    );
                }

                exerciseGrid.DataSource = exercisesTable;
            }
            else
            {
                MessageBox.Show("Respuesta inesperada: falta 'exercises'.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string term = searchBox.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(term))
            {
                usersTable.DefaultView.RowFilter = "";
                userGrid.DataSource = usersTable;
            }
            else
            {
                usersTable.DefaultView.RowFilter = $"fullname LIKE '%{term}%'";
                userGrid.DataSource = usersTable.DefaultView;
            }
        }

        private void viewEditButton_Click(object sender, EventArgs e)
        {
            if (userGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un usuario.");
                return;
            }

            int userId = Convert.ToInt32(userGrid.SelectedRows[0].Cells["id"].Value);

            using var detailsForm = new DetailsUser.DetailsUser(userId);
            detailsForm.ShowDialog();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (userGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un usuario.");
                return;
            }

            int userId = Convert.ToInt32(userGrid.SelectedRows[0].Cells["id"].Value);
            string userName = userGrid.SelectedRows[0].Cells["fullname"].Value.ToString();

            var confirmResult = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar a {userName}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var response = await client.DeleteAsync($"api/users/{userId}/");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.");
                        await LoadUsersAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Error al eliminar el usuario. Código: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión al eliminar usuario: " + ex.Message);
                }
            }
        }

        private async void addUserButton_Click(object sender, EventArgs e)
        {
            using var createUserForm = new CreateUser.CreateUser();
            var result = createUserForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                await LoadUsersAsync();
            }
        }

        private void exerciseSearchButton_Click(object sender, EventArgs e)
        {
            string term = exerciseSearchBox.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(term))
            {
                exercisesTable.DefaultView.RowFilter = "";
                exerciseGrid.DataSource = exercisesTable;
            }
            else
            {
                exercisesTable.DefaultView.RowFilter =
                    $"name LIKE '%{term}%' OR muscle LIKE '%{term}%'";
                exerciseGrid.DataSource = exercisesTable.DefaultView;
            }
        }

        private async void deleteExerciseButton_Click(object sender, EventArgs e)
        {
            if (exerciseGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un ejercicio.");
                return;
            }

            int exerciseId = Convert.ToInt32(exerciseGrid.SelectedRows[0].Cells["id"].Value);
            string exerciseName = exerciseGrid.SelectedRows[0].Cells["name"].Value.ToString();

            var confirmResult = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar el ejercicio \"{exerciseName}\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var response = await client.DeleteAsync($"api/exercises/{exerciseId}/");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Ejercicio eliminado correctamente.");
                        await LoadExercisesAsync();
                    }
                    else
                    {
                        MessageBox.Show($"Error al eliminar el ejercicio. Código: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión al eliminar el ejercicio: " + ex.Message);
                }
            }
        }

        private async void editExerciseButton_Click(object sender, EventArgs e)
        {
            if (exerciseGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un ejercicio.");
                return;
            }

            int exerciseId = Convert.ToInt32(exerciseGrid.SelectedRows[0].Cells["id"].Value);
            using var detailsForm = new DetailsExercise.DetailsExercise(exerciseId);

            if (detailsForm.ShowDialog() == DialogResult.OK)
            {
                await LoadExercisesAsync();
            }
        }

        private async void addExerciseButton_Click(object sender, EventArgs e)
        {
            using var createUserForm = new CreateExercise.CreateExercise();
            var result = createUserForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                await LoadExercisesAsync();
            }
        }

        private async void userGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (userGrid.SelectedRows.Count == 0)
                return;

            int userId = Convert.ToInt32(userGrid.SelectedRows[0].Cells["id"].Value);
            string userName = userGrid.SelectedRows[0].Cells["fullname"].Value.ToString();

            selectedUserLabel.Text = $"Usuario seleccionado: {userName}";

            try
            {
                var resp = await client.GetAsync($"api/foods/?user_id={userId}");
                resp.EnsureSuccessStatusCode();

                string json = await resp.Content.ReadAsStringAsync();
                var doc = JsonDocument.Parse(json).RootElement;

                if (doc.TryGetProperty("foods", out var foods))
                {
                    var foodTable = new DataTable();
                    foodTable.Columns.Add("id");
                    foodTable.Columns.Add("name");
                    foodTable.Columns.Add("calories");
                    foodTable.Columns.Add("serving_size_g");
                    foodTable.Columns.Add("fat_total_g");
                    foodTable.Columns.Add("protein_g");
                    foodTable.Columns.Add("carbohydrates_total_g");
                    foodTable.Columns.Add("cuantity");
                    foodTable.Columns.Add("food");
                    foodTable.Columns.Add("date");

                    foreach (var f in foods.EnumerateArray())
                    {
                        foodTable.Rows.Add(
                            f.GetProperty("id").GetInt32(),
                            f.GetProperty("name").GetString(),
                            f.GetProperty("calories").GetDecimal(),
                            f.GetProperty("serving_size_g").GetDecimal(),
                            f.GetProperty("fat_total_g").GetDecimal(),
                            f.GetProperty("protein_g").GetDecimal(),
                            f.GetProperty("carbohydrates_total_g").GetDecimal(),
                            f.GetProperty("cuantity").GetDecimal(),
                            f.GetProperty("food").GetString(),
                            f.GetProperty("date").GetString()
                        );
                    }

                    comidaGrid.DataSource = foodTable;
                }
                else
                {
                    comidaGrid.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar comidas: " + ex.Message);
            }
        }

        private async void filterFoodButton_Click(object sender, EventArgs e)
        {
            if (userGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario.");
                return;
            }

            int userId = Convert.ToInt32(userGrid.SelectedRows[0].Cells["id"].Value);
            string fecha = dtpFechaFiltro.Value.ToString("yyyy-MM-dd");

            try
            {
                var resp = await client.GetAsync($"api/foods/?user_id={userId}&date={fecha}");
                resp.EnsureSuccessStatusCode();

                string json = await resp.Content.ReadAsStringAsync();
                var doc = JsonDocument.Parse(json).RootElement;

                if (doc.TryGetProperty("foods", out var foods))
                {
                    var table = new DataTable();
                    table.Columns.Add("id");
                    table.Columns.Add("name");
                    table.Columns.Add("calories");
                    table.Columns.Add("serving_size_g");
                    table.Columns.Add("fat_total_g");
                    table.Columns.Add("protein_g");
                    table.Columns.Add("carbohydrates_total_g");
                    table.Columns.Add("cuantity");
                    table.Columns.Add("food");
                    table.Columns.Add("date");

                    foreach (var f in foods.EnumerateArray())
                    {
                        table.Rows.Add(
                            f.GetProperty("id").GetInt32(),
                            f.GetProperty("name").GetString(),
                            f.GetProperty("calories").GetDecimal(),
                            f.GetProperty("serving_size_g").GetDecimal(),
                            f.GetProperty("fat_total_g").GetDecimal(),
                            f.GetProperty("protein_g").GetDecimal(),
                            f.GetProperty("carbohydrates_total_g").GetDecimal(),
                            f.GetProperty("cuantity").GetDecimal(),
                            f.GetProperty("food").GetString(),
                            f.GetProperty("date").GetString()
                        );
                    }

                    comidaGrid.DataSource = table;
                    comidaGrid.Columns["id"].Visible = false;
                }
                else
                {
                    comidaGrid.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar comidas: " + ex.Message);
            }
        }

        private async void deleteFoodButton_Click(object sender, EventArgs e)
        {
            if (comidaGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una comida.");
                return;
            }
            if (!comidaGrid.Columns.Contains("id"))
            {
                MessageBox.Show("No se encontró el ID de la comida. Asegúrate de incluirlo en la carga.");
                return;
            }

            int foodId = Convert.ToInt32(comidaGrid.SelectedRows[0].Cells["id"].Value);
            string foodName = comidaGrid.SelectedRows[0].Cells["name"].Value.ToString();

            var confirm = MessageBox.Show(
                $"¿Deseas eliminar la comida \"{foodName}\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var response = await client.DeleteAsync($"api/foods/{foodId}/");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Comida eliminada correctamente.");

                        userGrid_SelectionChanged(null, null);
                    }
                    else
                    {
                        string errorMsg = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Error al eliminar: " + errorMsg);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
        }

        private async void addFoodButton_Click(object sender, EventArgs e)
        {
            if (userGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario primero.");
                return;
            }

            int userId = Convert.ToInt32(userGrid.SelectedRows[0].Cells["id"].Value);

            using var createFoodForm = new CreateFood.CreateFood(userId);
            var result = createFoodForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                userGrid_SelectionChanged(null, null);
            }
        }

        private async void editFoodButton_Click(object sender, EventArgs e)
        {
            if (comidaGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una comida para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedFoodId = Convert.ToInt32(comidaGrid.SelectedRows[0].Cells["id"].Value);

            using var form = new DetailsFood.DetailsFood(client, selectedFoodId);
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                userGrid_SelectionChanged(null, null);
            }
        }
    }
}
