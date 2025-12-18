namespace Kontoverwaltung
{
    partial class TransaktionsDetails
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
            lbTransaktionenAuftrageber = new Label();
            lbTransaktionenAuftrageberIBAN = new Label();
            lbTransaktionenEmpfeanger = new Label();
            lbTransaktionenEmpfeangerIBAN = new Label();
            lbTransaktionenVerwendungszweck = new Label();
            lbTransaktionenDatum = new Label();
            lbTransaktionenBetrag = new Label();
            btnTransaktionenClose = new Button();
            SuspendLayout();
            // 
            // lbTransaktionenAuftrageber
            // 
            lbTransaktionenAuftrageber.AutoSize = true;
            lbTransaktionenAuftrageber.Location = new Point(12, 9);
            lbTransaktionenAuftrageber.Name = "lbTransaktionenAuftrageber";
            lbTransaktionenAuftrageber.Size = new Size(83, 15);
            lbTransaktionenAuftrageber.TabIndex = 0;
            lbTransaktionenAuftrageber.Text = "Auftraggeber: ";
            // 
            // lbTransaktionenAuftrageberIBAN
            // 
            lbTransaktionenAuftrageberIBAN.AutoSize = true;
            lbTransaktionenAuftrageberIBAN.Location = new Point(12, 40);
            lbTransaktionenAuftrageberIBAN.Name = "lbTransaktionenAuftrageberIBAN";
            lbTransaktionenAuftrageberIBAN.Size = new Size(113, 15);
            lbTransaktionenAuftrageberIBAN.TabIndex = 1;
            lbTransaktionenAuftrageberIBAN.Text = "Auftraggeber IBAN: ";
            // 
            // lbTransaktionenEmpfeanger
            // 
            lbTransaktionenEmpfeanger.AutoSize = true;
            lbTransaktionenEmpfeanger.Location = new Point(12, 67);
            lbTransaktionenEmpfeanger.Name = "lbTransaktionenEmpfeanger";
            lbTransaktionenEmpfeanger.Size = new Size(74, 15);
            lbTransaktionenEmpfeanger.TabIndex = 2;
            lbTransaktionenEmpfeanger.Text = "Empfeanger:";
            // 
            // lbTransaktionenEmpfeangerIBAN
            // 
            lbTransaktionenEmpfeangerIBAN.AutoSize = true;
            lbTransaktionenEmpfeangerIBAN.Location = new Point(12, 100);
            lbTransaktionenEmpfeangerIBAN.Name = "lbTransaktionenEmpfeangerIBAN";
            lbTransaktionenEmpfeangerIBAN.Size = new Size(107, 15);
            lbTransaktionenEmpfeangerIBAN.TabIndex = 3;
            lbTransaktionenEmpfeangerIBAN.Text = "Empfeanger IBAN: ";
            // 
            // lbTransaktionenVerwendungszweck
            // 
            lbTransaktionenVerwendungszweck.AutoSize = true;
            lbTransaktionenVerwendungszweck.Location = new Point(12, 130);
            lbTransaktionenVerwendungszweck.Name = "lbTransaktionenVerwendungszweck";
            lbTransaktionenVerwendungszweck.Size = new Size(116, 15);
            lbTransaktionenVerwendungszweck.TabIndex = 4;
            lbTransaktionenVerwendungszweck.Text = "Verwendungszweck: ";
            // 
            // lbTransaktionenDatum
            // 
            lbTransaktionenDatum.AutoSize = true;
            lbTransaktionenDatum.Location = new Point(12, 162);
            lbTransaktionenDatum.Name = "lbTransaktionenDatum";
            lbTransaktionenDatum.Size = new Size(49, 15);
            lbTransaktionenDatum.TabIndex = 5;
            lbTransaktionenDatum.Text = "Datum: ";
            // 
            // lbTransaktionenBetrag
            // 
            lbTransaktionenBetrag.AutoSize = true;
            lbTransaktionenBetrag.Location = new Point(12, 195);
            lbTransaktionenBetrag.Name = "lbTransaktionenBetrag";
            lbTransaktionenBetrag.Size = new Size(47, 15);
            lbTransaktionenBetrag.TabIndex = 6;
            lbTransaktionenBetrag.Text = "Betrag: ";
            // 
            // btnTransaktionenClose
            // 
            btnTransaktionenClose.Location = new Point(11, 227);
            btnTransaktionenClose.Name = "btnTransaktionenClose";
            btnTransaktionenClose.Size = new Size(75, 23);
            btnTransaktionenClose.TabIndex = 9;
            btnTransaktionenClose.Text = "Schliessen";
            btnTransaktionenClose.UseVisualStyleBackColor = true;
            btnTransaktionenClose.Click += btnTransaktionenClose_Click;
            // 
            // TransaktionsDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 269);
            Controls.Add(btnTransaktionenClose);
            Controls.Add(lbTransaktionenBetrag);
            Controls.Add(lbTransaktionenDatum);
            Controls.Add(lbTransaktionenVerwendungszweck);
            Controls.Add(lbTransaktionenEmpfeangerIBAN);
            Controls.Add(lbTransaktionenEmpfeanger);
            Controls.Add(lbTransaktionenAuftrageberIBAN);
            Controls.Add(lbTransaktionenAuftrageber);
            Name = "TransaktionsDetails";
            Text = "TransaktionsDetails";
            Load += TransaktionsDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTransaktionenAuftrageber;
        private Label lbTransaktionenAuftrageberIBAN;
        private Label lbTransaktionenEmpfeanger;
        private Label lbTransaktionenEmpfeangerIBAN;
        private Label lbTransaktionenVerwendungszweck;
        private Label lbTransaktionenDatum;
        private Label lbTransaktionenBetrag;
        private Button btnTransaktionenClose;
    }
}