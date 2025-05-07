
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
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(30, 30);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Nombre completo";
            txtFullName.Size = new Size(300, 23);
            txtFullName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 2;
            // 
            // chkClient
            // 
            chkClient.AutoSize = true;
            chkClient.Location = new Point(30, 150);
            chkClient.Name = "chkClient";
            chkClient.Size = new Size(63, 19);
            chkClient.TabIndex = 3;
            chkClient.Text = "Cliente";
            // 
            // chkAdmin
            // 
            chkAdmin.AutoSize = true;
            chkAdmin.Location = new Point(150, 150);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(102, 19);
            chkAdmin.TabIndex = 4;
            chkAdmin.Text = "Administrador";
            // 
            // dtpEndSub
            // 
            dtpEndSub.Format = DateTimePickerFormat.Short;
            dtpEndSub.Location = new Point(30, 190);
            dtpEndSub.Name = "dtpEndSub";
            dtpEndSub.Size = new Size(300, 23);
            dtpEndSub.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 230);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.Click += btnSave_Click;


            followupGrid = new DataGridView();
            followupGrid.Location = new Point(360, 30);
            followupGrid.Size = new Size(540, 220);
            followupGrid.ReadOnly = true;
            followupGrid.AllowUserToAddRows = false;
            followupGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Controls.Add(followupGrid);

            // 
            // DetailsUser
            // 
            ClientSize = new Size(922, 452);
            Controls.Add(txtFullName);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(chkClient);
            Controls.Add(chkAdmin);
            Controls.Add(dtpEndSub);
            Controls.Add(btnSave);
            Name = "DetailsUser";
            Text = "Detalles del Usuario";
            Load += DetailsUser_Load;
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

    }
}
