namespace DetailsFood
{
    partial class DetailsFood
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblCalorias = new Label();
            txtCalorias = new TextBox();
            lblProteina = new Label();
            txtProteina = new TextBox();
            lblGrasa = new Label();
            txtGrasa = new TextBox();
            lblCarbohidratos = new Label();
            txtCarbohidratos = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(20, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblTipo
            // 
            lblTipo.Location = new Point(20, 60);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(100, 23);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo (Desayuno, Almuerzo, Cena):";
            // 
            // cmbTipo
            // 
            cmbTipo.Items.AddRange(new object[] { "Desayuno", "Almuerzo", "Cena" });
            cmbTipo.Location = new Point(250, 60);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(150, 23);
            cmbTipo.TabIndex = 3;
            // 
            // lblCantidad
            // 
            lblCantidad.Location = new Point(20, 100);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(100, 23);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad (g):";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(150, 100);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 5;
            // 
            // lblCalorias
            // 
            lblCalorias.Location = new Point(20, 140);
            lblCalorias.Name = "lblCalorias";
            lblCalorias.Size = new Size(100, 23);
            lblCalorias.TabIndex = 6;
            lblCalorias.Text = "Calorías:";
            // 
            // txtCalorias
            // 
            txtCalorias.Location = new Point(150, 140);
            txtCalorias.Name = "txtCalorias";
            txtCalorias.Size = new Size(100, 23);
            txtCalorias.TabIndex = 7;
            // 
            // lblProteina
            // 
            lblProteina.Location = new Point(20, 180);
            lblProteina.Name = "lblProteina";
            lblProteina.Size = new Size(100, 23);
            lblProteina.TabIndex = 8;
            lblProteina.Text = "Proteína (g):";
            // 
            // txtProteina
            // 
            txtProteina.Location = new Point(150, 180);
            txtProteina.Name = "txtProteina";
            txtProteina.Size = new Size(100, 23);
            txtProteina.TabIndex = 9;
            // 
            // lblGrasa
            // 
            lblGrasa.Location = new Point(20, 220);
            lblGrasa.Name = "lblGrasa";
            lblGrasa.Size = new Size(100, 23);
            lblGrasa.TabIndex = 10;
            lblGrasa.Text = "Grasa total (g):";
            // 
            // txtGrasa
            // 
            txtGrasa.Location = new Point(150, 220);
            txtGrasa.Name = "txtGrasa";
            txtGrasa.Size = new Size(100, 23);
            txtGrasa.TabIndex = 11;
            // 
            // lblCarbohidratos
            // 
            lblCarbohidratos.Location = new Point(20, 260);
            lblCarbohidratos.Name = "lblCarbohidratos";
            lblCarbohidratos.Size = new Size(100, 23);
            lblCarbohidratos.TabIndex = 12;
            lblCarbohidratos.Text = "Carbohidratos (g):";
            // 
            // txtCarbohidratos
            // 
            txtCarbohidratos.Location = new Point(150, 260);
            txtCarbohidratos.Name = "txtCarbohidratos";
            txtCarbohidratos.Size = new Size(100, 23);
            txtCarbohidratos.TabIndex = 13;
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(20, 300);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(100, 23);
            lblFecha.TabIndex = 14;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(150, 300);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(150, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += BtnGuardar_Click;
            // 
            // DetailsFood
            // 
            ClientSize = new Size(450, 400);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipo);
            Controls.Add(lblCantidad);
            Controls.Add(txtCantidad);
            Controls.Add(lblCalorias);
            Controls.Add(txtCalorias);
            Controls.Add(lblProteina);
            Controls.Add(txtProteina);
            Controls.Add(lblGrasa);
            Controls.Add(txtGrasa);
            Controls.Add(lblCarbohidratos);
            Controls.Add(txtCarbohidratos);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(btnGuardar);
            Name = "DetailsFood";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar Comida";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label lblCalorias;
        private TextBox txtCalorias;
        private Label lblProteina;
        private TextBox txtProteina;
        private Label lblGrasa;
        private TextBox txtGrasa;
        private Label lblCarbohidratos;
        private TextBox txtCarbohidratos;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;

    }
}
