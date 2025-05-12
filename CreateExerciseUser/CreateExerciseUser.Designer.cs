namespace CreateExerciseUser
{
    partial class CreateExerciseUser
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
            comboExercises = new ComboBox();
            numPeso = new NumericUpDown();
            numReps = new NumericUpDown();
            numSets = new NumericUpDown();
            numRest = new NumericUpDown();
            datePicker = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblEjercicio = new Label();
            lblPeso = new Label();
            lblReps = new Label();
            lblSets = new Label();
            lblRest = new Label();
            lblFecha = new Label();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRest).BeginInit();
            SuspendLayout();
            // 
            // comboExercises
            // 
            comboExercises.DropDownStyle = ComboBoxStyle.DropDownList;
            comboExercises.Location = new Point(150, 30);
            comboExercises.Name = "comboExercises";
            comboExercises.Size = new Size(300, 28);
            comboExercises.TabIndex = 1;
            // 
            // numPeso
            // 
            numPeso.Location = new Point(150, 80);
            numPeso.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(120, 27);
            numPeso.TabIndex = 3;
            // 
            // numReps
            // 
            numReps.Location = new Point(150, 130);
            numReps.Name = "numReps";
            numReps.Size = new Size(120, 27);
            numReps.TabIndex = 5;
            // 
            // numSets
            // 
            numSets.Location = new Point(150, 180);
            numSets.Name = "numSets";
            numSets.Size = new Size(120, 27);
            numSets.TabIndex = 7;
            // 
            // numRest
            // 
            numRest.Location = new Point(150, 230);
            numRest.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numRest.Name = "numRest";
            numRest.Size = new Size(120, 27);
            numRest.TabIndex = 9;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(150, 280);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 27);
            datePicker.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(150, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(270, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            // 
            // lblEjercicio
            // 
            lblEjercicio.Location = new Point(30, 30);
            lblEjercicio.Name = "lblEjercicio";
            lblEjercicio.Size = new Size(100, 25);
            lblEjercicio.TabIndex = 0;
            lblEjercicio.Text = "Ejercicio:";
            // 
            // lblPeso
            // 
            lblPeso.Location = new Point(30, 80);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(100, 25);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso (kg):";
            // 
            // lblReps
            // 
            lblReps.Location = new Point(30, 130);
            lblReps.Name = "lblReps";
            lblReps.Size = new Size(100, 25);
            lblReps.TabIndex = 4;
            lblReps.Text = "Repeticiones:";
            // 
            // lblSets
            // 
            lblSets.Location = new Point(30, 180);
            lblSets.Name = "lblSets";
            lblSets.Size = new Size(100, 25);
            lblSets.TabIndex = 6;
            lblSets.Text = "Series:";
            // 
            // lblRest
            // 
            lblRest.Location = new Point(30, 230);
            lblRest.Name = "lblRest";
            lblRest.Size = new Size(100, 25);
            lblRest.TabIndex = 8;
            lblRest.Text = "Descanso (s):";
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(30, 280);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(100, 25);
            lblFecha.TabIndex = 10;
            lblFecha.Text = "Fecha:";
            // 
            // CreateExerciseUser
            // 
            ClientSize = new Size(500, 400);
            Controls.Add(lblEjercicio);
            Controls.Add(comboExercises);
            Controls.Add(lblPeso);
            Controls.Add(numPeso);
            Controls.Add(lblReps);
            Controls.Add(numReps);
            Controls.Add(lblSets);
            Controls.Add(numSets);
            Controls.Add(lblRest);
            Controls.Add(numRest);
            Controls.Add(lblFecha);
            Controls.Add(datePicker);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Name = "CreateExerciseUser";
            Text = "Asignar Ejercicio al Usuario";
            Load += CreateExerciseUser_Load;
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSets).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRest).EndInit();
            ResumeLayout(false);
        }


        #endregion
        private ComboBox comboExercises;
        private NumericUpDown numPeso;
        private NumericUpDown numReps;
        private NumericUpDown numSets;
        private NumericUpDown numRest;
        private DateTimePicker datePicker;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblEjercicio;
        private Label lblPeso;
        private Label lblReps;
        private Label lblSets;
        private Label lblRest;
        private Label lblFecha;
    }
}
