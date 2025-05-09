namespace CreateUser
{
    partial class CreateUser
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
            btnCreate = new Button();

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
            // btnCreate
            // 
            btnCreate.Location = new Point(30, 230);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 30);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 300);
            Controls.Add(txtFullName);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(chkClient);
            Controls.Add(chkAdmin);
            Controls.Add(dtpEndSub);
            Controls.Add(btnCreate);
            Name = "CreateUser";
            Text = "Nuevo Usuario";
            StartPosition = FormStartPosition.CenterParent;
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
        private Button btnCreate;
    }
}
