using System.Text.Json;
using System.Text;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

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

                //DATOS DEL USUARIO
                txtFullName.Text = root.GetProperty("fullname").GetString();
                txtEmail.Text = root.GetProperty("email").GetString();
                txtPassword.Text = root.GetProperty("password").GetString();
                chkClient.Checked = root.GetProperty("client").GetBoolean();
                chkAdmin.Checked = root.GetProperty("admin").GetBoolean();
                if (root.TryGetProperty("end_sub", out JsonElement endSub) && endSub.ValueKind != JsonValueKind.Null)
                {
                    dtpEndSub.Value = DateTime.Parse(endSub.GetString());
                }

                // SEGUIMIENTOS
                if (root.TryGetProperty("followups", out JsonElement followups))
                {
                    var table = new DataTable();
                    table.Columns.Add("Fecha");
                    table.Columns.Add("Peso");
                    table.Columns.Add("IMC");
                    table.Columns.Add("Grasa");
                    table.Columns.Add("GET");
                    table.Columns.Add("Altura");
                    table.Columns.Add("Observaciones");

                    var seriesPeso = chartFollowups.Series["Peso corporal"];
                    var seriesIMC = chartIMC.Series["IMC"];
                    var seriesFat = chartFat.Series["Grasa corporal"];
                    var seriesGET = chartGET.Series["Gasto energético total (GET)"];

                    seriesPeso.Points.Clear();
                    seriesIMC.Points.Clear();
                    seriesFat.Points.Clear();
                    seriesGET.Points.Clear();

                    var areaPeso = chartFollowups.ChartAreas["MainArea"];
                    areaPeso.AxisX.Title = "Fecha";
                    areaPeso.AxisX.LabelStyle.Format = "dd/MM/yyyy";
                    areaPeso.AxisX.MajorGrid.LineColor = Color.LightGray;
                    areaPeso.AxisY.Title = "Peso (kg)";
                    areaPeso.AxisY.MajorGrid.LineColor = Color.LightGray;

                    var areaIMC = chartIMC.ChartAreas["MainArea"];
                    areaIMC.AxisX.Title = "Fecha";
                    areaIMC.AxisX.LabelStyle.Format = "dd/MM/yyyy";
                    areaIMC.AxisX.MajorGrid.LineColor = Color.LightGray;
                    areaIMC.AxisY.Title = "IMC";
                    areaIMC.AxisY.MajorGrid.LineColor = Color.LightGray;

                    var areaFat = chartFat.ChartAreas["MainArea"];
                    areaFat.AxisX.Title = "Fecha";
                    areaFat.AxisX.LabelStyle.Format = "dd/MM/yyyy";
                    areaFat.AxisX.MajorGrid.LineColor = Color.LightGray;
                    areaFat.AxisY.Title = "Grasa (%)";
                    areaFat.AxisY.MajorGrid.LineColor = Color.LightGray;

                    var areaGET = chartGET.ChartAreas["MainArea"];
                    areaGET.AxisX.Title = "Fecha";
                    areaGET.AxisX.LabelStyle.Format = "dd/MM/yyyy";
                    areaGET.AxisX.MajorGrid.LineColor = Color.LightGray;
                    areaGET.AxisY.Title = "GET";
                    areaGET.AxisY.MajorGrid.LineColor = Color.LightGray;

                    foreach (var f in followups.EnumerateArray())
                    {
                        string dateStr = f.GetProperty("date").GetString();
                        DateTime date = DateTime.Parse(dateStr);
                        int weight = f.GetProperty("weight").GetInt32();
                        string imc = f.TryGetProperty("imc", out var imcVal) ? imcVal.ToString() : "";
                        string fat = f.TryGetProperty("fat", out var fatVal) ? fatVal.ToString() : "";
                        string get = f.TryGetProperty("get", out var getVal) ? getVal.ToString() : "";
                        string height = f.TryGetProperty("height", out var h) ? h.ToString() : "";
                        string obs = f.TryGetProperty("observations", out var o) ? o.GetString() : "";
                        table.Rows.Add(dateStr, weight.ToString(), imc, fat, get, height, obs);
                        seriesPeso.Points.AddXY(date, weight);

                        if (imcVal.ValueKind == JsonValueKind.Number)
                            seriesIMC.Points.AddXY(date, imcVal.GetInt32());

                        if (fatVal.ValueKind == JsonValueKind.Number)
                            seriesFat.Points.AddXY(date, fatVal.GetInt32());

                        if (getVal.ValueKind == JsonValueKind.Number)
                            seriesGET.Points.AddXY(date, getVal.GetInt32());
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


        private async void followupGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = followupGrid.Rows[e.RowIndex];

            if (!DateTime.TryParse(row.Cells["Fecha"].Value?.ToString(), out DateTime fecha))
                return;

            // Preparar el cuerpo del seguimiento modificado
            var seguimiento = new Dictionary<string, object>
            {
                ["date_follow"] = fecha.ToString("yyyy-MM-dd"),
                ["weight"] = int.TryParse(row.Cells["Peso"].Value?.ToString(), out int peso) ? peso : 0,
                ["imc"] = int.TryParse(row.Cells["IMC"].Value?.ToString(), out int imc) ? imc : (int?)null,
                ["fat"] = int.TryParse(row.Cells["Grasa"].Value?.ToString(), out int grasa) ? grasa : (int?)null,
                ["get"] = int.TryParse(row.Cells["GET"].Value?.ToString(), out int get) ? get : (int?)null,
                ["height"] = int.TryParse(row.Cells["Altura"].Value?.ToString(), out int altura) ? altura : (int?)null,
                ["observations"] = row.Cells["Observaciones"].Value?.ToString() ?? ""
            };

            // Serializar y enviar PUT
            string json = JsonSerializer.Serialize(seguimiento);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"api/followups/{_idUsuario}/{fecha:yyyy-MM-dd}/", content);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Error al actualizar el seguimiento.");
                return;
            }

            // Recargar la tabla y gráficos
            var refresh = await client.GetAsync($"api/users/{_idUsuario}/");
            if (!refresh.IsSuccessStatusCode)
            {
                MessageBox.Show("Error al recargar los datos.");
                return;
            }

            var jsonData = await refresh.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(jsonData);
            var root = doc.RootElement;

            if (root.TryGetProperty("followups", out JsonElement followups))
            {
                var table = new DataTable();
                table.Columns.Add("Fecha");
                table.Columns.Add("Peso");
                table.Columns.Add("IMC");
                table.Columns.Add("Grasa");
                table.Columns.Add("GET");
                table.Columns.Add("Altura");
                table.Columns.Add("Observaciones");

                var sPeso = chartFollowups.Series["Peso corporal"];
                var sIMC = chartIMC.Series["IMC"];
                var sFat = chartFat.Series["Grasa corporal"];
                var sGET = chartGET.Series["Gasto energético total (GET)"];

                sPeso.Points.Clear(); sIMC.Points.Clear(); sFat.Points.Clear(); sGET.Points.Clear();

                foreach (var f in followups.EnumerateArray())
                {
                    string dateStr = f.GetProperty("date").GetString();
                    DateTime d = DateTime.Parse(dateStr);
                    int w = f.GetProperty("weight").GetInt32();

                    string imcStr = f.TryGetProperty("imc", out var imcVal) ? imcVal.ToString() : "";
                    string fatStr = f.TryGetProperty("fat", out var fatVal) ? fatVal.ToString() : "";
                    string getStr = f.TryGetProperty("get", out var getVal) ? getVal.ToString() : "";
                    string hStr = f.TryGetProperty("height", out var hVal) ? hVal.ToString() : "";
                    string obsStr = f.TryGetProperty("observations", out var oVal) ? oVal.GetString() : "";

                    table.Rows.Add(dateStr, w.ToString(), imcStr, fatStr, getStr, hStr, obsStr);

                    sPeso.Points.AddXY(d, w);
                    if (imcVal.ValueKind == JsonValueKind.Number) sIMC.Points.AddXY(d, imcVal.GetInt32());
                    if (fatVal.ValueKind == JsonValueKind.Number) sFat.Points.AddXY(d, fatVal.GetInt32());
                    if (getVal.ValueKind == JsonValueKind.Number) sGET.Points.AddXY(d, getVal.GetInt32());
                }

                followupGrid.DataSource = table;
            }
        }


    }
}
