namespace Kontoverwaltung
{
    partial class Hauptfenster
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
            header = new Label();
            login = new Label();
            loginName = new Label();
            loginPassword = new Label();
            tbLoginPassword = new TextBox();
            tbLoginName = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            btnExit = new Button();
            meldungen = new Label();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.Location = new Point(210, 9);
            header.Name = "header";
            header.Size = new Size(81, 15);
            header.TabIndex = 0;
            header.Text = "Login-Bereich";
            header.UseMnemonic = false;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Location = new Point(12, 36);
            login.Name = "login";
            login.Size = new Size(43, 15);
            login.TabIndex = 1;
            login.Text = "Login: ";
            // 
            // loginName
            // 
            loginName.AutoSize = true;
            loginName.Location = new Point(12, 81);
            loginName.Name = "loginName";
            loginName.Size = new Size(83, 15);
            loginName.TabIndex = 2;
            loginName.Text = "Login-Name : ";
            // 
            // loginPassword
            // 
            loginPassword.AutoSize = true;
            loginPassword.Location = new Point(12, 110);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(63, 15);
            loginPassword.TabIndex = 3;
            loginPassword.Text = "Passwort : ";
            // 
            // tbLoginPassword
            // 
            tbLoginPassword.Location = new Point(101, 102);
            tbLoginPassword.Name = "tbLoginPassword";
            tbLoginPassword.Size = new Size(100, 23);
            tbLoginPassword.TabIndex = 4;
            // 
            // tbLoginName
            // 
            tbLoginName.Location = new Point(101, 73);
            tbLoginName.Name = "tbLoginName";
            tbLoginName.Size = new Size(100, 23);
            tbLoginName.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 152);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(94, 152);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(79, 23);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Registrieren";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(179, 152);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(79, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Beenden";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // meldungen
            // 
            meldungen.AutoSize = true;
            meldungen.Location = new Point(12, 276);
            meldungen.Name = "meldungen";
            meldungen.Size = new Size(0, 15);
            meldungen.TabIndex = 9;
            // 
            // Hauptfenster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(meldungen);
            Controls.Add(btnExit);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(tbLoginName);
            Controls.Add(tbLoginPassword);
            Controls.Add(loginPassword);
            Controls.Add(loginName);
            Controls.Add(login);
            Controls.Add(header);
            Name = "Hauptfenster";
            Text = "Kontoverwaltung";
            FormClosing += Hauptfenster_FormClosing;
            Load += Hauptfenster_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private Label login;
        private Label loginName;
        private Label loginPassword;
        private TextBox tbLoginName;
        private TextBox tbLoginPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnExit;
        private Label meldungen;
    }
}
