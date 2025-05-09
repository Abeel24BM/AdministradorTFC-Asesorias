namespace AdministradorTFC
{
    partial class Administrador
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
            groupAdministrador = new GroupBox();
            searchBox = new TextBox();
            searchButton = new Button();
            userGrid = new DataGridView();
            addUserButton = new Button();
            viewEditButton = new Button();
            deleteButton = new Button();
            groupLogin = new GroupBox();
            label1 = new Label();
            email = new TextBox();
            label2 = new Label();
            password = new TextBox();
            loginButton = new Button();
            groupEjercicios = new GroupBox();
            exerciseSearchBox = new TextBox();
            exerciseSearchButton = new Button();
            exerciseGrid = new DataGridView();
            addExerciseButton = new Button();
            editExerciseButton = new Button();
            deleteExerciseButton = new Button();
            groupComidas = new GroupBox();
            selectedUserLabel = new Label();
            filterFoodButton = new Button();
            comidaGrid = new DataGridView();
            addFoodButton = new Button();
            editFoodButton = new Button();
            deleteFoodButton = new Button();
            groupAdministrador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userGrid).BeginInit();
            groupLogin.SuspendLayout();
            groupEjercicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exerciseGrid).BeginInit();
            groupComidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comidaGrid).BeginInit();
            SuspendLayout();
            // 
            // groupAdministrador
            // 
            groupAdministrador.Controls.Add(searchBox);
            groupAdministrador.Controls.Add(searchButton);
            groupAdministrador.Controls.Add(userGrid);
            groupAdministrador.Controls.Add(addUserButton);
            groupAdministrador.Controls.Add(viewEditButton);
            groupAdministrador.Controls.Add(deleteButton);
            groupAdministrador.Location = new Point(12, 12);
            groupAdministrador.Name = "groupAdministrador";
            groupAdministrador.Size = new Size(747, 388);
            groupAdministrador.TabIndex = 0;
            groupAdministrador.TabStop = false;
            groupAdministrador.Text = "Gestión de usuarios";
            groupAdministrador.Visible = false;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(10, 22);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(150, 23);
            searchBox.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(170, 20);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 25);
            searchButton.TabIndex = 1;
            searchButton.Text = "Buscar";
            searchButton.Click += searchButton_Click;
            // 
            // userGrid
            // 
            userGrid.Location = new Point(10, 55);
            userGrid.Name = "userGrid";
            userGrid.Size = new Size(731, 298);
            userGrid.TabIndex = 2;
            // 
            // addUserButton
            // 
            addUserButton.Location = new Point(10, 359);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(75, 23);
            addUserButton.TabIndex = 6;
            addUserButton.Text = "Añadir";
            addUserButton.Click += addUserButton_Click;
            // 
            // viewEditButton
            // 
            viewEditButton.Location = new Point(170, 359);
            viewEditButton.Name = "viewEditButton";
            viewEditButton.Size = new Size(75, 23);
            viewEditButton.TabIndex = 3;
            viewEditButton.Text = "Ver/Editar";
            viewEditButton.Click += viewEditButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(90, 359);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Eliminar";
            deleteButton.Click += deleteButton_Click;
            // 
            // groupLogin
            // 
            groupLogin.Anchor = AnchorStyles.None;
            groupLogin.Controls.Add(label1);
            groupLogin.Controls.Add(email);
            groupLogin.Controls.Add(label2);
            groupLogin.Controls.Add(password);
            groupLogin.Controls.Add(loginButton);
            groupLogin.Location = new Point(600, 415);
            groupLogin.Name = "groupLogin";
            groupLogin.Size = new Size(300, 180);
            groupLogin.TabIndex = 3;
            groupLogin.TabStop = false;
            groupLogin.Text = "Iniciar sesión";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // email
            // 
            email.Location = new Point(10, 50);
            email.Name = "email";
            email.Size = new Size(280, 23);
            email.TabIndex = 1;
            email.Text = "abelblanco24@gmail.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 85);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // password
            // 
            password.Location = new Point(10, 105);
            password.Name = "password";
            password.Size = new Size(280, 23);
            password.TabIndex = 3;
            password.Text = "#b1NsnS8KA";
            password.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(10, 140);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(280, 30);
            loginButton.TabIndex = 4;
            loginButton.Text = "Iniciar sesión";
            loginButton.Click += loginButton_Click;
            // 
            // groupEjercicios
            // 
            groupEjercicios.Controls.Add(exerciseSearchBox);
            groupEjercicios.Controls.Add(exerciseSearchButton);
            groupEjercicios.Controls.Add(exerciseGrid);
            groupEjercicios.Controls.Add(addExerciseButton);
            groupEjercicios.Controls.Add(editExerciseButton);
            groupEjercicios.Controls.Add(deleteExerciseButton);
            groupEjercicios.Location = new Point(12, 406);
            groupEjercicios.Name = "groupEjercicios";
            groupEjercicios.Size = new Size(747, 512);
            groupEjercicios.TabIndex = 1;
            groupEjercicios.TabStop = false;
            groupEjercicios.Text = "Gestión de ejercicios";
            groupEjercicios.Visible = false;
            // 
            // exerciseSearchBox
            // 
            exerciseSearchBox.Location = new Point(10, 22);
            exerciseSearchBox.Name = "exerciseSearchBox";
            exerciseSearchBox.Size = new Size(150, 23);
            exerciseSearchBox.TabIndex = 0;
            // 
            // exerciseSearchButton
            // 
            exerciseSearchButton.Location = new Point(170, 20);
            exerciseSearchButton.Name = "exerciseSearchButton";
            exerciseSearchButton.Size = new Size(75, 25);
            exerciseSearchButton.TabIndex = 1;
            exerciseSearchButton.Text = "Buscar";
            exerciseSearchButton.Click += exerciseSearchButton_Click;
            // 
            // exerciseGrid
            // 
            exerciseGrid.Location = new Point(10, 55);
            exerciseGrid.Name = "exerciseGrid";
            exerciseGrid.Size = new Size(731, 422);
            exerciseGrid.TabIndex = 2;
            // 
            // addExerciseButton
            // 
            addExerciseButton.Location = new Point(10, 483);
            addExerciseButton.Name = "addExerciseButton";
            addExerciseButton.Size = new Size(75, 23);
            addExerciseButton.TabIndex = 6;
            addExerciseButton.Text = "Añadir";
            addExerciseButton.Click += addExerciseButton_Click;
            // 
            // editExerciseButton
            // 
            editExerciseButton.Location = new Point(170, 483);
            editExerciseButton.Name = "editExerciseButton";
            editExerciseButton.Size = new Size(75, 23);
            editExerciseButton.TabIndex = 3;
            editExerciseButton.Text = "Editar";
            editExerciseButton.Click += editExerciseButton_Click;
            // 
            // deleteExerciseButton
            // 
            deleteExerciseButton.Location = new Point(90, 483);
            deleteExerciseButton.Name = "deleteExerciseButton";
            deleteExerciseButton.Size = new Size(75, 23);
            deleteExerciseButton.TabIndex = 4;
            deleteExerciseButton.Text = "Eliminar";
            deleteExerciseButton.Click += deleteExerciseButton_Click;
            // 
            // groupComidas
            // 
            groupComidas.Controls.Add(selectedUserLabel);
            groupComidas.Controls.Add(filterFoodButton);
            groupComidas.Controls.Add(comidaGrid);
            groupComidas.Controls.Add(addFoodButton);
            groupComidas.Controls.Add(editFoodButton);
            groupComidas.Controls.Add(deleteFoodButton);
            groupComidas.Location = new Point(765, 12);
            groupComidas.Name = "groupComidas";
            groupComidas.Size = new Size(944, 388);
            groupComidas.TabIndex = 2;
            groupComidas.TabStop = false;
            groupComidas.Text = "Registro de comidas";
            groupComidas.Visible = false;
            // 
            // selectedUserLabel
            // 
            selectedUserLabel.Location = new Point(10, 22);
            selectedUserLabel.Name = "selectedUserLabel";
            selectedUserLabel.Size = new Size(200, 23);
            selectedUserLabel.TabIndex = 0;
            selectedUserLabel.Text = "Usuario seleccionado:";
            // 
            // filterFoodButton
            // 
            filterFoodButton.Location = new Point(220, 20);
            filterFoodButton.Name = "filterFoodButton";
            filterFoodButton.Size = new Size(75, 25);
            filterFoodButton.TabIndex = 1;
            filterFoodButton.Text = "Filtrar";
            // 
            // comidaGrid
            // 
            comidaGrid.Location = new Point(10, 55);
            comidaGrid.Name = "comidaGrid";
            comidaGrid.Size = new Size(928, 298);
            comidaGrid.TabIndex = 2;
            // 
            // addFoodButton
            // 
            addFoodButton.Location = new Point(10, 359);
            addFoodButton.Name = "addFoodButton";
            addFoodButton.Size = new Size(75, 23);
            addFoodButton.TabIndex = 3;
            addFoodButton.Text = "Añadir";
            // 
            // editFoodButton
            // 
            editFoodButton.Location = new Point(170, 359);
            editFoodButton.Name = "editFoodButton";
            editFoodButton.Size = new Size(75, 23);
            editFoodButton.TabIndex = 5;
            editFoodButton.Text = "Editar";
            // 
            // deleteFoodButton
            // 
            deleteFoodButton.Location = new Point(90, 359);
            deleteFoodButton.Name = "deleteFoodButton";
            deleteFoodButton.Size = new Size(75, 23);
            deleteFoodButton.TabIndex = 4;
            deleteFoodButton.Text = "Eliminar";
            // 
            // Administrador
            // 
            ClientSize = new Size(1878, 930);
            Controls.Add(groupLogin);
            Controls.Add(groupAdministrador);
            Controls.Add(groupEjercicios);
            Controls.Add(groupComidas);
            Name = "Administrador";
            Load += Administrador_Load;
            groupAdministrador.ResumeLayout(false);
            groupAdministrador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userGrid).EndInit();
            groupLogin.ResumeLayout(false);
            groupLogin.PerformLayout();
            groupEjercicios.ResumeLayout(false);
            groupEjercicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)exerciseGrid).EndInit();
            groupComidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)comidaGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupAdministrador;
        private TextBox searchBox;
        private Button searchButton;
        private DataGridView userGrid;
        private Button viewEditButton;
        private Button deleteButton;
        private Button addUserButton;
        private TextBox exerciseSearchBox;
        private Button exerciseSearchButton;
        private DataGridView exerciseGrid;
        private Button editExerciseButton;
        private Button deleteExerciseButton;
        private Button addExerciseButton;

        private GroupBox groupComidas;
        private Label selectedUserLabel;
        private DataGridView comidaGrid;
        private Button addFoodButton;
        private Button editFoodButton;
        private Button deleteFoodButton;
        private Button filterFoodButton;
        private GroupBox groupEjercicios;
        private Button loginButton;
        private Label label1;
        private TextBox email;
        private Label label2;
        private TextBox password;
        private GroupBox groupLogin;
    }
}
