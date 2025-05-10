namespace CreateFood
{
    partial class CreateFood
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            btnBuscar = new Button();
            lstResultados = new ListBox();
            txtName = new TextBox();
            txtCalories = new TextBox();
            txtProtein = new TextBox();
            txtFat = new TextBox();
            txtCarbs = new TextBox();
            txtQuantity = new TextBox();
            cmbTipo = new ComboBox();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();

            SuspendLayout();

            // txtSearch
            txtSearch.Location = new Point(20, 20);
            txtSearch.Size = new Size(200, 23);
            txtSearch.PlaceholderText = "Buscar alimento";

            // btnBuscar
            btnBuscar.Location = new Point(230, 20);
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += BtnBuscar_Click;

            // lstResultados
            lstResultados.Location = new Point(20, 55);
            lstResultados.Size = new Size(285, 80);
            lstResultados.SelectedIndexChanged += LstResultados_SelectedIndexChanged;

            // txtName
            txtName.Location = new Point(330, 20);
            txtName.Size = new Size(200, 23);
            txtName.PlaceholderText = "Nombre del alimento";

            // txtCalories
            txtCalories.Location = new Point(330, 55);
            txtCalories.Size = new Size(95, 23);
            txtCalories.PlaceholderText = "Calorías";

            // txtProtein
            txtProtein.Location = new Point(435, 55);
            txtProtein.Size = new Size(95, 23);
            txtProtein.PlaceholderText = "Proteínas";

            // txtFat
            txtFat.Location = new Point(330, 90);
            txtFat.Size = new Size(95, 23);
            txtFat.PlaceholderText = "Grasas";

            // txtCarbs
            txtCarbs.Location = new Point(435, 90);
            txtCarbs.Size = new Size(95, 23);
            txtCarbs.PlaceholderText = "Carbs";

            // txtQuantity
            txtQuantity.Location = new Point(330, 125);
            txtQuantity.Size = new Size(200, 23);
            txtQuantity.PlaceholderText = "Cantidad (g/ml)";
            txtQuantity.TextChanged += TxtQuantity_TextChanged;

            // cmbTipo
            cmbTipo.Location = new Point(330, 160);
            cmbTipo.Size = new Size(200, 23);
            cmbTipo.Items.AddRange(new string[] { "Desayuno", "Almuerzo", "Cena" });
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            // dtpFecha
            dtpFecha.Location = new Point(330, 195);
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.Format = DateTimePickerFormat.Short;

            // btnGuardar
            btnGuardar.Location = new Point(330, 230);
            btnGuardar.Size = new Size(200, 30);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += BtnGuardar_Click;

            // Form
            ClientSize = new Size(600, 280);
            Controls.AddRange(new Control[]
            {
            txtSearch, btnBuscar, lstResultados,
            txtName, txtCalories, txtProtein, txtFat, txtCarbs,
            txtQuantity, cmbTipo, dtpFecha, btnGuardar
            });
            Text = "Añadir Comida";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private TextBox txtSearch;
        private Button btnBuscar;
        private ListBox lstResultados;
        private TextBox txtName;
        private TextBox txtCalories;
        private TextBox txtProtein;
        private TextBox txtFat;
        private TextBox txtCarbs;
        private TextBox txtQuantity;
        private ComboBox cmbTipo;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;
    }
}
