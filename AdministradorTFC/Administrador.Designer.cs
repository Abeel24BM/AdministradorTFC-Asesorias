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
            dtpFechaFiltro = new DateTimePicker();
            groupEjerciciosUsuario = new GroupBox();
            userExerciseGrid = new DataGridView();
            addUserExerciseButton = new Button();
            editUserExerciseButton = new Button();
            deleteUserExerciseButton = new Button();
            userExerciseFilterDate = new DateTimePicker();
            filterUserExerciseButton = new Button();
            groupAdministrador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userGrid).BeginInit();
            groupLogin.SuspendLayout();
            groupEjercicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exerciseGrid).BeginInit();
            groupComidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comidaGrid).BeginInit();
            groupEjerciciosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userExerciseGrid).BeginInit();
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
            searchBox.Size = new Size(150, 27);
            searchBox.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(170, 20);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 29);
            searchButton.TabIndex = 1;
            searchButton.Text = "Buscar";
            searchButton.Click += searchButton_Click;
            // 
            // userGrid
            // 
            userGrid.ColumnHeadersHeight = 29;
            userGrid.Location = new Point(10, 55);
            userGrid.Name = "userGrid";
            userGrid.RowHeadersWidth = 51;
            userGrid.Size = new Size(731, 298);
            userGrid.TabIndex = 2;
            userGrid.SelectionChanged += userGrid_SelectionChanged;
            // 
            // addUserButton
            // 
            addUserButton.Location = new Point(10, 359);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(75, 29);
            addUserButton.TabIndex = 3;
            addUserButton.Text = "Añadir";
            addUserButton.Click += addUserButton_Click;
            // 
            // viewEditButton
            // 
            viewEditButton.Location = new Point(170, 359);
            viewEditButton.Name = "viewEditButton";
            viewEditButton.Size = new Size(75, 29);
            viewEditButton.TabIndex = 4;
            viewEditButton.Text = "Ver/Editar";
            viewEditButton.Click += viewEditButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(90, 359);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 29);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Eliminar";
            deleteButton.Click += deleteButton_Click;
            // 
            // groupLogin
            // 
            groupLogin.Controls.Add(label1);
            groupLogin.Controls.Add(email);
            groupLogin.Controls.Add(label2);
            groupLogin.Controls.Add(password);
            groupLogin.Controls.Add(loginButton);
            groupLogin.Location = new Point(1878, 930);
            groupLogin.Name = "groupLogin";
            groupLogin.Size = new Size(300, 180);
            groupLogin.TabIndex = 4;
            groupLogin.TabStop = false;
            groupLogin.Text = "Iniciar sesión";
            // 
            // label1
            // 
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // email
            // 
            email.Location = new Point(10, 50);
            email.Name = "email";
            email.Size = new Size(280, 27);
            email.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(10, 85);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // password
            // 
            password.Location = new Point(10, 105);
            password.Name = "password";
            password.Size = new Size(280, 27);
            password.TabIndex = 3;
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
            groupEjercicios.Location = new Point(12, 410);
            groupEjercicios.Name = "groupEjercicios";
            groupEjercicios.Size = new Size(747, 508);
            groupEjercicios.TabIndex = 1;
            groupEjercicios.TabStop = false;
            groupEjercicios.Text = "Gestión de ejercicios";
            groupEjercicios.Visible = false;
            // 
            // exerciseSearchBox
            // 
            exerciseSearchBox.Location = new Point(10, 22);
            exerciseSearchBox.Name = "exerciseSearchBox";
            exerciseSearchBox.Size = new Size(150, 27);
            exerciseSearchBox.TabIndex = 0;
            // 
            // exerciseSearchButton
            // 
            exerciseSearchButton.Location = new Point(170, 20);
            exerciseSearchButton.Name = "exerciseSearchButton";
            exerciseSearchButton.Size = new Size(75, 29);
            exerciseSearchButton.TabIndex = 1;
            exerciseSearchButton.Text = "Buscar";
            exerciseSearchButton.Click += exerciseSearchButton_Click;
            // 
            // exerciseGrid
            // 
            exerciseGrid.ColumnHeadersHeight = 29;
            exerciseGrid.Location = new Point(10, 55);
            exerciseGrid.Name = "exerciseGrid";
            exerciseGrid.RowHeadersWidth = 51;
            exerciseGrid.Size = new Size(721, 392);
            exerciseGrid.TabIndex = 2;
            // 
            // addExerciseButton
            // 
            addExerciseButton.Location = new Point(10, 462);
            addExerciseButton.Name = "addExerciseButton";
            addExerciseButton.Size = new Size(75, 30);
            addExerciseButton.TabIndex = 3;
            addExerciseButton.Text = "Añadir";
            addExerciseButton.Click += addExerciseButton_Click;
            // 
            // editExerciseButton
            // 
            editExerciseButton.Location = new Point(170, 462);
            editExerciseButton.Name = "editExerciseButton";
            editExerciseButton.Size = new Size(75, 30);
            editExerciseButton.TabIndex = 4;
            editExerciseButton.Text = "Editar";
            editExerciseButton.Click += editExerciseButton_Click;
            // 
            // deleteExerciseButton
            // 
            deleteExerciseButton.Location = new Point(90, 462);
            deleteExerciseButton.Name = "deleteExerciseButton";
            deleteExerciseButton.Size = new Size(75, 30);
            deleteExerciseButton.TabIndex = 5;
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
            groupComidas.Controls.Add(dtpFechaFiltro);
            groupComidas.Location = new Point(765, 12);
            groupComidas.Name = "groupComidas";
            groupComidas.Size = new Size(1050, 388);
            groupComidas.TabIndex = 2;
            groupComidas.TabStop = false;
            groupComidas.Text = "Registro de comidas";
            groupComidas.Visible = false;
            // 
            // selectedUserLabel
            // 
            selectedUserLabel.Location = new Point(10, 22);
            selectedUserLabel.Name = "selectedUserLabel";
            selectedUserLabel.Size = new Size(300, 23);
            selectedUserLabel.TabIndex = 0;
            // 
            // filterFoodButton
            // 
            filterFoodButton.Location = new Point(450, 16);
            filterFoodButton.Name = "filterFoodButton";
            filterFoodButton.Size = new Size(75, 29);
            filterFoodButton.TabIndex = 1;
            filterFoodButton.Text = "Filtrar";
            filterFoodButton.Click += filterFoodButton_Click;
            // 
            // comidaGrid
            // 
            comidaGrid.ColumnHeadersHeight = 29;
            comidaGrid.Location = new Point(10, 55);
            comidaGrid.Name = "comidaGrid";
            comidaGrid.RowHeadersWidth = 51;
            comidaGrid.Size = new Size(1020, 298);
            comidaGrid.TabIndex = 2;
            // 
            // addFoodButton
            // 
            addFoodButton.Location = new Point(10, 359);
            addFoodButton.Name = "addFoodButton";
            addFoodButton.Size = new Size(75, 29);
            addFoodButton.TabIndex = 3;
            addFoodButton.Text = "Añadir";
            addFoodButton.Click += addFoodButton_Click;
            // 
            // editFoodButton
            // 
            editFoodButton.Location = new Point(170, 359);
            editFoodButton.Name = "editFoodButton";
            editFoodButton.Size = new Size(75, 29);
            editFoodButton.TabIndex = 4;
            editFoodButton.Text = "Editar";
            editFoodButton.Click += editFoodButton_Click;
            // 
            // deleteFoodButton
            // 
            deleteFoodButton.Location = new Point(90, 359);
            deleteFoodButton.Name = "deleteFoodButton";
            deleteFoodButton.Size = new Size(75, 29);
            deleteFoodButton.TabIndex = 5;
            deleteFoodButton.Text = "Eliminar";
            deleteFoodButton.Click += deleteFoodButton_Click;
            // 
            // dtpFechaFiltro
            // 
            dtpFechaFiltro.CustomFormat = " ";
            dtpFechaFiltro.Format = DateTimePickerFormat.Custom;
            dtpFechaFiltro.Location = new Point(320, 18);
            dtpFechaFiltro.Name = "dtpFechaFiltro";
            dtpFechaFiltro.Size = new Size(120, 27);
            dtpFechaFiltro.TabIndex = 6;
            dtpFechaFiltro.ValueChanged += dtpFechaFiltro_ValueChanged;
            // 
            // groupEjerciciosUsuario
            // 
            groupEjerciciosUsuario.Controls.Add(userExerciseGrid);
            groupEjerciciosUsuario.Controls.Add(addUserExerciseButton);
            groupEjerciciosUsuario.Controls.Add(editUserExerciseButton);
            groupEjerciciosUsuario.Controls.Add(deleteUserExerciseButton);
            groupEjerciciosUsuario.Controls.Add(userExerciseFilterDate);
            groupEjerciciosUsuario.Controls.Add(filterUserExerciseButton);
            groupEjerciciosUsuario.Location = new Point(765, 410);
            groupEjerciciosUsuario.Name = "groupEjerciciosUsuario";
            groupEjerciciosUsuario.Size = new Size(1050, 508);
            groupEjerciciosUsuario.TabIndex = 3;
            groupEjerciciosUsuario.TabStop = false;
            groupEjerciciosUsuario.Text = "Ejercicios del usuario";
            groupEjerciciosUsuario.Visible = false;
            // 
            // userExerciseGrid
            // 
            userExerciseGrid.ColumnHeadersHeight = 29;
            userExerciseGrid.Location = new Point(10, 55);
            userExerciseGrid.Name = "userExerciseGrid";
            userExerciseGrid.RowHeadersWidth = 51;
            userExerciseGrid.Size = new Size(1020, 392);
            userExerciseGrid.TabIndex = 0;
            // 
            // addUserExerciseButton
            // 
            addUserExerciseButton.Location = new Point(10, 462);
            addUserExerciseButton.Name = "addUserExerciseButton";
            addUserExerciseButton.Size = new Size(75, 30);
            addUserExerciseButton.TabIndex = 1;
            addUserExerciseButton.Text = "Añadir";
            addUserExerciseButton.Click += addUserExerciseButton_Click;
            // 
            // editUserExerciseButton
            // 
            editUserExerciseButton.Location = new Point(171, 462);
            editUserExerciseButton.Name = "editUserExerciseButton";
            editUserExerciseButton.Size = new Size(75, 30);
            editUserExerciseButton.TabIndex = 2;
            editUserExerciseButton.Text = "Editar";
            editUserExerciseButton.Click += editUserExerciseButton_Click;
            // 
            // deleteUserExerciseButton
            // 
            deleteUserExerciseButton.Location = new Point(90, 462);
            deleteUserExerciseButton.Name = "deleteUserExerciseButton";
            deleteUserExerciseButton.Size = new Size(75, 30);
            deleteUserExerciseButton.TabIndex = 3;
            deleteUserExerciseButton.Text = "Eliminar";
            deleteUserExerciseButton.Click += deleteUserExerciseButton_Click;
            // 
            // userExerciseFilterDate
            // 
            userExerciseFilterDate.CustomFormat = " ";
            userExerciseFilterDate.Format = DateTimePickerFormat.Custom;
            userExerciseFilterDate.Location = new Point(320, 22);
            userExerciseFilterDate.Name = "userExerciseFilterDate";
            userExerciseFilterDate.Size = new Size(120, 27);
            userExerciseFilterDate.TabIndex = 4;
            userExerciseFilterDate.ValueChanged += userExerciseFilterDate_ValueChanged;
            // 
            // filterUserExerciseButton
            // 
            filterUserExerciseButton.Location = new Point(450, 22);
            filterUserExerciseButton.Name = "filterUserExerciseButton";
            filterUserExerciseButton.Size = new Size(75, 27);
            filterUserExerciseButton.TabIndex = 5;
            filterUserExerciseButton.Text = "Filtrar";
            filterUserExerciseButton.Click += filterUserExerciseButton_Click;
            // 
            // Administrador
            // 
            ClientSize = new Size(1878, 930);
            Controls.Add(groupAdministrador);
            Controls.Add(groupEjercicios);
            Controls.Add(groupComidas);
            Controls.Add(groupEjerciciosUsuario);
            Controls.Add(groupLogin);
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
            groupEjerciciosUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userExerciseGrid).EndInit();
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
        private DateTimePicker dtpFechaFiltro;
        private GroupBox groupEjercicios;
        private Button loginButton;
        private Label label1;
        private TextBox email;
        private Label label2;
        private TextBox password;
        private GroupBox groupLogin;

        private GroupBox groupEjerciciosUsuario;
        private DataGridView userExerciseGrid;
        private Button addUserExerciseButton;
        private Button editUserExerciseButton;
        private Button deleteUserExerciseButton;
        private DateTimePicker userExerciseFilterDate;
        private Button filterUserExerciseButton;

    }
}
