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
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Buscar alimento";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(230, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // lstResultados
            // 
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(20, 55);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(285, 79);
            lstResultados.TabIndex = 2;
            lstResultados.SelectedIndexChanged += LstResultados_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(330, 20);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nombre del alimento";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 3;
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(330, 55);
            txtCalories.Name = "txtCalories";
            txtCalories.PlaceholderText = "Calorías";
            txtCalories.Size = new Size(95, 23);
            txtCalories.TabIndex = 4;
            // 
            // txtProtein
            // 
            txtProtein.Location = new Point(435, 55);
            txtProtein.Name = "txtProtein";
            txtProtein.PlaceholderText = "Proteínas";
            txtProtein.Size = new Size(95, 23);
            txtProtein.TabIndex = 5;
            // 
            // txtFat
            // 
            txtFat.Location = new Point(330, 90);
            txtFat.Name = "txtFat";
            txtFat.PlaceholderText = "Grasas";
            txtFat.Size = new Size(95, 23);
            txtFat.TabIndex = 6;
            // 
            // txtCarbs
            // 
            txtCarbs.Location = new Point(435, 90);
            txtCarbs.Name = "txtCarbs";
            txtCarbs.PlaceholderText = "Carbs";
            txtCarbs.Size = new Size(95, 23);
            txtCarbs.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(330, 125);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Cantidad (g/ml)";
            txtQuantity.Size = new Size(200, 23);
            txtQuantity.TabIndex = 8;
            txtQuantity.TextChanged += TxtQuantity_TextChanged;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Items.AddRange(new object[] { "Desayuno", "Almuerzo", "Cena" });
            cmbTipo.Location = new Point(330, 160);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(200, 23);
            cmbTipo.TabIndex = 9;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(330, 195);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(330, 230);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(200, 30);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += BtnGuardar_Click;
            // 
            // CreateFood
            // 
            ClientSize = new Size(600, 280);
            Controls.Add(txtSearch);
            Controls.Add(btnBuscar);
            Controls.Add(lstResultados);
            Controls.Add(txtName);
            Controls.Add(txtCalories);
            Controls.Add(txtProtein);
            Controls.Add(txtFat);
            Controls.Add(txtCarbs);
            Controls.Add(txtQuantity);
            Controls.Add(cmbTipo);
            Controls.Add(dtpFecha);
            Controls.Add(btnGuardar);
            Name = "CreateFood";
            Text = "Añadir Comida";
            Load += CreateFood_Load;
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
