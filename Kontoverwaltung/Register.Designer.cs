namespace Kontoverwaltung
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            btnRegister = new Button();
            tbLoginName = new TextBox();
            tbLoginPassword = new TextBox();
            loginPassword = new Label();
            loginName = new Label();
            login = new Label();
            header = new Label();
            tbrUserName = new TextBox();
            userName = new Label();
            registerMeldungen = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(105, 171);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 23);
            btnBack.TabIndex = 17;
            btnBack.Text = "Zurueck";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(20, 171);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(79, 23);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Registrieren";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbLoginName
            // 
            tbLoginName.Location = new Point(105, 92);
            tbLoginName.Name = "tbLoginName";
            tbLoginName.Size = new Size(100, 23);
            tbLoginName.TabIndex = 14;
            // 
            // tbLoginPassword
            // 
            tbLoginPassword.Location = new Point(105, 121);
            tbLoginPassword.Name = "tbLoginPassword";
            tbLoginPassword.Size = new Size(100, 23);
            tbLoginPassword.TabIndex = 13;
            // 
            // loginPassword
            // 
            loginPassword.AutoSize = true;
            loginPassword.Location = new Point(16, 129);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(63, 15);
            loginPassword.TabIndex = 12;
            loginPassword.Text = "Passwort : ";
            // 
            // loginName
            // 
            loginName.AutoSize = true;
            loginName.Location = new Point(16, 100);
            loginName.Name = "loginName";
            loginName.Size = new Size(83, 15);
            loginName.TabIndex = 11;
            loginName.Text = "Login-Name : ";
            // 
            // login
            // 
            login.AutoSize = true;
            login.Location = new Point(16, 36);
            login.Name = "login";
            login.Size = new Size(82, 15);
            login.TabIndex = 10;
            login.Text = "Login-Daten : ";
            // 
            // header
            // 
            header.AutoSize = true;
            header.Location = new Point(167, 9);
            header.Name = "header";
            header.Size = new Size(147, 15);
            header.TabIndex = 9;
            header.Text = "Neu Registierungs-Bereich";
            header.UseMnemonic = false;
            // 
            // tbrUserName
            // 
            tbrUserName.Location = new Point(105, 63);
            tbrUserName.Name = "tbrUserName";
            tbrUserName.Size = new Size(100, 23);
            tbrUserName.TabIndex = 18;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(16, 71);
            userName.Name = "userName";
            userName.Size = new Size(76, 15);
            userName.TabIndex = 19;
            userName.Text = "User-Name : ";
            // 
            // registerMeldungen
            // 
            registerMeldungen.AutoSize = true;
            registerMeldungen.Location = new Point(12, 276);
            registerMeldungen.Name = "registerMeldungen";
            registerMeldungen.Size = new Size(0, 15);
            registerMeldungen.TabIndex = 20;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(registerMeldungen);
            Controls.Add(userName);
            Controls.Add(tbrUserName);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(tbLoginName);
            Controls.Add(tbLoginPassword);
            Controls.Add(loginPassword);
            Controls.Add(loginName);
            Controls.Add(login);
            Controls.Add(header);
            Name = "Register";
            Text = "Register";
            FormClosing += Register_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnRegister;
        private TextBox tbLoginName;
        private TextBox tbLoginPassword;
        private Label loginPassword;
        private Label loginName;
        private Label login;
        private Label header;
        private TextBox tbrUserName;
        private Label userName;
        private Label registerMeldungen;
    }
}