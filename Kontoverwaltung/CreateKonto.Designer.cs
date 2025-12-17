namespace Kontoverwaltung
{
    partial class CreateKonto
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
            inhaber = new Label();
            btnCreateKontoBack = new Button();
            btnCreate = new Button();
            tfBAN = new TextBox();
            kontoart = new Label();
            iban = new Label();
            login = new Label();
            header = new Label();
            ibanVorkennung = new Label();
            cbGiro = new CheckBox();
            cbSparkonto = new CheckBox();
            lbInhaber = new Label();
            meldungen = new Label();
            SuspendLayout();
            // 
            // inhaber
            // 
            inhaber.AutoSize = true;
            inhaber.Location = new Point(14, 71);
            inhaber.Name = "inhaber";
            inhaber.Size = new Size(56, 15);
            inhaber.TabIndex = 29;
            inhaber.Text = "Inhaber : ";
            // 
            // btnCreateKontoBack
            // 
            btnCreateKontoBack.Location = new Point(103, 171);
            btnCreateKontoBack.Name = "btnCreateKontoBack";
            btnCreateKontoBack.Size = new Size(79, 23);
            btnCreateKontoBack.TabIndex = 27;
            btnCreateKontoBack.Text = "Zurueck";
            btnCreateKontoBack.UseVisualStyleBackColor = true;
            btnCreateKontoBack.Click += btnCreateKontoBack_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(18, 171);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(79, 23);
            btnCreate.TabIndex = 26;
            btnCreate.Text = "Eroeffnen";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // tfBAN
            // 
            tfBAN.Location = new Point(140, 92);
            tfBAN.Name = "tfBAN";
            tfBAN.Size = new Size(100, 23);
            tfBAN.TabIndex = 25;
            // 
            // kontoart
            // 
            kontoart.AutoSize = true;
            kontoart.Location = new Point(14, 129);
            kontoart.Name = "kontoart";
            kontoart.Size = new Size(62, 15);
            kontoart.TabIndex = 23;
            kontoart.Text = "Kontoart : ";
            // 
            // iban
            // 
            iban.AutoSize = true;
            iban.Location = new Point(14, 100);
            iban.Name = "iban";
            iban.Size = new Size(43, 15);
            iban.TabIndex = 22;
            iban.Text = "IBAN : ";
            // 
            // login
            // 
            login.AutoSize = true;
            login.Location = new Point(14, 36);
            login.Name = "login";
            login.Size = new Size(82, 15);
            login.TabIndex = 21;
            login.Text = "Konto Daten : ";
            // 
            // header
            // 
            header.AutoSize = true;
            header.Location = new Point(175, 9);
            header.Name = "header";
            header.Size = new Size(143, 15);
            header.TabIndex = 20;
            header.Text = "Konto Erstellungs-Bereich";
            header.UseMnemonic = false;
            // 
            // ibanVorkennung
            // 
            ibanVorkennung.AutoSize = true;
            ibanVorkennung.Location = new Point(101, 100);
            ibanVorkennung.Name = "ibanVorkennung";
            ibanVorkennung.Size = new Size(33, 15);
            ibanVorkennung.TabIndex = 30;
            ibanVorkennung.Text = "DE96";
            // 
            // cbGiro
            // 
            cbGiro.AutoSize = true;
            cbGiro.Location = new Point(140, 125);
            cbGiro.Name = "cbGiro";
            cbGiro.Size = new Size(79, 19);
            cbGiro.TabIndex = 31;
            cbGiro.Text = "Girokonto";
            cbGiro.UseVisualStyleBackColor = true;
            // 
            // cbSparkonto
            // 
            cbSparkonto.AutoSize = true;
            cbSparkonto.Location = new Point(225, 125);
            cbSparkonto.Name = "cbSparkonto";
            cbSparkonto.Size = new Size(80, 19);
            cbSparkonto.TabIndex = 32;
            cbSparkonto.Text = "Sparkonto";
            cbSparkonto.UseVisualStyleBackColor = true;
            // 
            // lbInhaber
            // 
            lbInhaber.AutoSize = true;
            lbInhaber.Location = new Point(140, 71);
            lbInhaber.Name = "lbInhaber";
            lbInhaber.Size = new Size(0, 15);
            lbInhaber.TabIndex = 33;
            // 
            // meldungen
            // 
            meldungen.AutoSize = true;
            meldungen.Location = new Point(12, 276);
            meldungen.Name = "meldungen";
            meldungen.Size = new Size(0, 15);
            meldungen.TabIndex = 34;
            // 
            // CreateKonto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(meldungen);
            Controls.Add(lbInhaber);
            Controls.Add(cbSparkonto);
            Controls.Add(cbGiro);
            Controls.Add(ibanVorkennung);
            Controls.Add(inhaber);
            Controls.Add(btnCreateKontoBack);
            Controls.Add(btnCreate);
            Controls.Add(tfBAN);
            Controls.Add(kontoart);
            Controls.Add(iban);
            Controls.Add(login);
            Controls.Add(header);
            Name = "CreateKonto";
            Text = "CreateKonto";
            FormClosing += CreateKonto_FormClosing;
            Load += CreateKonto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label inhaber;
        private TextBox tbrUserName;
        private Button btnCreateKontoBack;
        private Button btnCreate;
        private TextBox tfBAN;
        private Label kontoart;
        private Label iban;
        private Label login;
        private Label header;
        private Label ibanVorkennung;
        private CheckBox cbGiro;
        private CheckBox cbSparkonto;
        private Label lbInhaber;
        private Label meldungen;
    }
}