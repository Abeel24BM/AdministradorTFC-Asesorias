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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkClient = new System.Windows.Forms.CheckBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.dtpEndSub = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtFullName
            this.txtFullName.Location = new System.Drawing.Point(30, 30);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(300, 23);
            this.txtFullName.PlaceholderText = "Nombre completo";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(30, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 23);
            this.txtEmail.PlaceholderText = "Email";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(30, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 23);
            this.txtPassword.PlaceholderText = "Contraseña";
            this.txtPassword.PasswordChar = '*';

            // chkClient
            this.chkClient.Location = new System.Drawing.Point(30, 150);
            this.chkClient.Text = "Cliente";
            this.chkClient.AutoSize = true;

            // chkAdmin
            this.chkAdmin.Location = new System.Drawing.Point(150, 150);
            this.chkAdmin.Text = "Administrador";
            this.chkAdmin.AutoSize = true;

            // dtpEndSub
            this.dtpEndSub.Location = new System.Drawing.Point(30, 190);
            this.dtpEndSub.Name = "dtpEndSub";
            this.dtpEndSub.Size = new System.Drawing.Size(300, 23);
            this.dtpEndSub.Format = DateTimePickerFormat.Short;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(30, 230);
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.chkClient);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.dtpEndSub);
            this.Controls.Add(this.btnSave);
            this.Name = "DetailsUser";
            this.Text = "Detalles del Usuario";
            this.Load += new System.EventHandler(this.DetailsUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private CheckBox chkClient;
        private CheckBox chkAdmin;
        private DateTimePicker dtpEndSub;
        private Button btnSave;
    }
}
