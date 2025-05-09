namespace DetailsExercise
{
    partial class DetailsExercise
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
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtRecommendations = new TextBox();
            txtVideoUrl = new TextBox();
            cmbMuscleGroup = new ComboBox();
            btnSave = new Button();
            videoBrowser = new WebBrowser();

            SuspendLayout();

            // txtName
            txtName.Location = new Point(30, 30);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nombre del ejercicio";
            txtName.Size = new Size(300, 23);

            // txtDescription
            txtDescription.Location = new Point(30, 70);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Descripción";
            txtDescription.Multiline = true;
            txtDescription.Size = new Size(300, 60);

            // txtRecommendations
            txtRecommendations.Location = new Point(30, 140);
            txtRecommendations.Name = "txtRecommendations";
            txtRecommendations.PlaceholderText = "Recomendaciones";
            txtRecommendations.Size = new Size(300, 23);

            // txtVideoUrl
            txtVideoUrl.Location = new Point(30, 180);
            txtVideoUrl.Name = "txtVideoUrl";
            txtVideoUrl.PlaceholderText = "URL del video";
            txtVideoUrl.Size = new Size(300, 23);
            txtVideoUrl.Leave += TxtVideoUrl_Leave;

            // cmbMuscleGroup
            cmbMuscleGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMuscleGroup.Location = new Point(30, 220);
            cmbMuscleGroup.Name = "cmbMuscleGroup";
            cmbMuscleGroup.Size = new Size(300, 23);

            // btnSave
            btnSave.Location = new Point(30, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;

            // videoBrowser (iframe simulation)
            videoBrowser.Location = new Point(360, 30);
            videoBrowser.Name = "videoBrowser";
            videoBrowser.Size = new Size(400, 250);

            // DetailsExercise
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 320);
            Controls.Add(txtName);
            Controls.Add(txtDescription);
            Controls.Add(txtRecommendations);
            Controls.Add(txtVideoUrl);
            Controls.Add(cmbMuscleGroup);
            Controls.Add(btnSave);
            Controls.Add(videoBrowser);
            Name = "DetailsExercise";
            Text = "Detalles del Ejercicio";
            Load += DetailsExercise_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtRecommendations;
        private TextBox txtVideoUrl;
        private ComboBox cmbMuscleGroup;
        private Button btnSave;
        private WebBrowser videoBrowser;
    }
}
