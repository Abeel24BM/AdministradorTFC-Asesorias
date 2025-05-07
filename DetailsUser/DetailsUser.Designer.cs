
using System.Windows.Forms.DataVisualization.Charting;
namespace DetailsUser
{
    partial class DetailsUser
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
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            chkClient = new CheckBox();
            chkAdmin = new CheckBox();
            dtpEndSub = new DateTimePicker();
            btnSave = new Button();
            followupGrid = new DataGridView();
            chartFollowups = new Chart();
            chartIMC = new Chart();
            chartFat = new Chart();
            chartGET = new Chart();
            ((System.ComponentModel.ISupportInitialize)followupGrid).BeginInit();
            SuspendLayout();
            // txtFullName
            txtFullName.Location = new Point(30, 30);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Nombre completo";
            txtFullName.Size = new Size(300, 23);
            txtFullName.TabIndex = 0;
            // txtEmail
            txtEmail.Location = new Point(30, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 1;
            // txtPassword
            txtPassword.Location = new Point(30, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 2;
            // chkClient
            chkClient.AutoSize = true;
            chkClient.Location = new Point(30, 150);
            chkClient.Name = "chkClient";
            chkClient.Size = new Size(63, 19);
            chkClient.TabIndex = 3;
            chkClient.Text = "Cliente";
            // chkAdmin
            chkAdmin.AutoSize = true;
            chkAdmin.Location = new Point(150, 150);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(102, 19);
            chkAdmin.TabIndex = 4;
            chkAdmin.Text = "Administrador";
            // dtpEndSub
            dtpEndSub.Format = DateTimePickerFormat.Short;
            dtpEndSub.Location = new Point(30, 190);
            dtpEndSub.Name = "dtpEndSub";
            dtpEndSub.Size = new Size(300, 23);
            dtpEndSub.TabIndex = 5;
            // btnSave
            btnSave.Location = new Point(30, 230);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.Click += btnSave_Click;
            // followupGrid
            followupGrid.AllowUserToAddRows = false;
            followupGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            followupGrid.Location = new Point(360, 30);
            followupGrid.Name = "followupGrid";
            followupGrid.ReadOnly = false;
            followupGrid.AllowUserToAddRows = true;
            followupGrid.AllowUserToDeleteRows = true;
            followupGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            followupGrid.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            followupGrid.Size = new Size(770, 220);
            followupGrid.TabIndex = 7;
            followupGrid.CellValueChanged += followupGrid_CellValueChanged;

            // chartFollowups (Peso)
            chartFollowups.Location = new Point(30, 280);
            chartFollowups.Size = new Size(1100, 150);
            ChartArea areaPeso = new ChartArea("MainArea");
            chartFollowups.ChartAreas.Add(areaPeso);
            Series seriesPeso = new Series("Peso corporal");
            chartFollowups.Series.Add(seriesPeso);
            chartFollowups.Legends.Add(new Legend("Leyenda"));
            Controls.Add(chartFollowups);
            // chartIMC
            chartIMC.Location = new Point(30, 450);
            chartIMC.Size = new Size(1100, 150);
            ChartArea areaIMC = new ChartArea("MainArea");
            chartIMC.ChartAreas.Add(areaIMC);
            Series seriesIMC = new Series("IMC");
            chartIMC.Series.Add(seriesIMC);
            chartIMC.Legends.Add(new Legend("Leyenda"));
            Controls.Add(chartIMC);
            // chartFat
            chartFat.Location = new Point(30, 630);
            chartFat.Size = new Size(1100, 150);
            ChartArea areaFat = new ChartArea("MainArea");
            chartFat.ChartAreas.Add(areaFat);
            Series seriesFat = new Series("Grasa corporal");
            chartFat.Series.Add(seriesFat);
            chartFat.Legends.Add(new Legend("Leyenda"));
            Controls.Add(chartFat);
            // chartGET
            chartGET.Location = new Point(30, 810);
            chartGET.Size = new Size(1100, 150);
            ChartArea areaGET = new ChartArea("MainArea");
            chartGET.ChartAreas.Add(areaGET);
            Series seriesGET = new Series("Gasto energético total (GET)");
            chartGET.Series.Add(seriesGET);
            chartGET.Legends.Add(new Legend("Leyenda"));
            Controls.Add(chartGET);
            // DetailsUser Form
            // DetailsUser Form
            ClientSize = new Size(1200, 1000);
            StartPosition = FormStartPosition.CenterScreen;
            Controls.Add(txtFullName);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(chkClient);
            Controls.Add(chkAdmin);
            Controls.Add(dtpEndSub);
            Controls.Add(btnSave);
            Controls.Add(followupGrid);
            Name = "DetailsUser";
            Text = "Detalles del Usuario";
            Load += DetailsUser_Load;
            ((System.ComponentModel.ISupportInitialize)followupGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private CheckBox chkClient;
        private CheckBox chkAdmin;
        private DateTimePicker dtpEndSub;
        private Button btnSave;
        private DataGridView followupGrid;
        private Chart chartFollowups;
        private Chart chartIMC;
        private Chart chartFat;
        private Chart chartGET;

    }
}
