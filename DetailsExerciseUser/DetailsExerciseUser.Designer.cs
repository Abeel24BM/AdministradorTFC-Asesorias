namespace DetailsExerciseUser
{
    partial class DetailsExerciseUser
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

            SuspendLayout();

            lblEjercicio.Text = "Ejercicio:";
            lblEjercicio.Location = new Point(30, 30);
            lblEjercicio.Size = new Size(100, 25);

            lblPeso.Text = "Peso (kg):";
            lblPeso.Location = new Point(30, 80);

            lblReps.Text = "Repeticiones:";
            lblReps.Location = new Point(30, 130);

            lblSets.Text = "Series:";
            lblSets.Location = new Point(30, 180);

            lblRest.Text = "Descanso (s):";
            lblRest.Location = new Point(30, 230);

            lblFecha.Text = "Fecha:";
            lblFecha.Location = new Point(30, 280);

            comboExercises.Location = new Point(150, 30);
            comboExercises.Size = new Size(300, 28);
            comboExercises.DropDownStyle = ComboBoxStyle.DropDownList;

            numPeso.Location = new Point(150, 80);
            numPeso.Maximum = 500;

            numReps.Location = new Point(150, 130);
            numReps.Maximum = 100;

            numSets.Location = new Point(150, 180);
            numSets.Maximum = 100;

            numRest.Location = new Point(150, 230);
            numRest.Maximum = 600;

            datePicker.Location = new Point(150, 280);
            datePicker.Format = DateTimePickerFormat.Short;

            btnGuardar.Text = "Guardar";
            btnGuardar.Location = new Point(150, 340);
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.Click += btnGuardar_Click;

            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(270, 340);
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            ClientSize = new Size(500, 400);
            Controls.AddRange(new Control[] {
                lblEjercicio, comboExercises,
                lblPeso, numPeso,
                lblReps, numReps,
                lblSets, numSets,
                lblRest, numRest,
                lblFecha, datePicker,
                btnGuardar, btnCancelar
            });

            Text = "Editar Ejercicio de Usuario";
            Load += DetailsExerciseUser_Load;
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
