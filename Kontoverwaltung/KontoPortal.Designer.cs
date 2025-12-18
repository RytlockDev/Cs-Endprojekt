namespace Kontoverwaltung
{
    partial class KontoPortal
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
            kundenPortal = new TabControl();
            kontoDetails = new TabPage();
            tbBetragEinzahlenAuszahlen = new TextBox();
            lbBetragEinzahlenAuszahlen = new Label();
            btnAuszahlen = new Button();
            btnEinzahlen = new Button();
            btnKontoSelect = new Button();
            btnKontoDelete = new Button();
            btnKontoCreate = new Button();
            Kontouebersicht = new ListBox();
            kontoAuszug = new TabPage();
            btnTransaktionDetails = new Button();
            Transaktionsliste = new ListBox();
            kontoUeberweisung = new TabPage();
            tbVerwendungszweck = new TextBox();
            tbBetrag = new TextBox();
            tbIBAN = new TextBox();
            btnUeberweisen = new Button();
            ueberweisungAusfuehrungsdatum = new Label();
            dtpAusfuehrungsdatum = new DateTimePicker();
            cbDauerauftrag = new CheckBox();
            ueberweisungVerwendungszweck = new Label();
            ueberweisungBetrag = new Label();
            ueberweisungIBAN = new Label();
            ueberweisungEmpfeangerName = new Label();
            ueberweisungEmpfeanger = new Label();
            kontoDauerauftrag = new TabPage();
            btnDauerauftragLoeschen = new Button();
            Dauerauftreage = new ListBox();
            header = new Label();
            btnLogout = new Button();
            verwaltungMeldungen = new Label();
            kundenPortal.SuspendLayout();
            kontoDetails.SuspendLayout();
            kontoAuszug.SuspendLayout();
            kontoUeberweisung.SuspendLayout();
            kontoDauerauftrag.SuspendLayout();
            SuspendLayout();
            // 
            // kundenPortal
            // 
            kundenPortal.Controls.Add(kontoDetails);
            kundenPortal.Controls.Add(kontoAuszug);
            kundenPortal.Controls.Add(kontoUeberweisung);
            kundenPortal.Controls.Add(kontoDauerauftrag);
            kundenPortal.Location = new Point(0, 28);
            kundenPortal.Name = "kundenPortal";
            kundenPortal.SelectedIndex = 0;
            kundenPortal.Size = new Size(800, 421);
            kundenPortal.TabIndex = 6;
            // 
            // kontoDetails
            // 
            kontoDetails.Controls.Add(tbBetragEinzahlenAuszahlen);
            kontoDetails.Controls.Add(lbBetragEinzahlenAuszahlen);
            kontoDetails.Controls.Add(btnAuszahlen);
            kontoDetails.Controls.Add(btnEinzahlen);
            kontoDetails.Controls.Add(btnKontoSelect);
            kontoDetails.Controls.Add(btnKontoDelete);
            kontoDetails.Controls.Add(btnKontoCreate);
            kontoDetails.Controls.Add(Kontouebersicht);
            kontoDetails.Location = new Point(4, 24);
            kontoDetails.Name = "kontoDetails";
            kontoDetails.Padding = new Padding(3);
            kontoDetails.Size = new Size(792, 393);
            kontoDetails.TabIndex = 0;
            kontoDetails.Text = "Konto Details";
            kontoDetails.UseVisualStyleBackColor = true;
            // 
            // tbBetragEinzahlenAuszahlen
            // 
            tbBetragEinzahlenAuszahlen.Location = new Point(137, 194);
            tbBetragEinzahlenAuszahlen.Name = "tbBetragEinzahlenAuszahlen";
            tbBetragEinzahlenAuszahlen.Size = new Size(123, 23);
            tbBetragEinzahlenAuszahlen.TabIndex = 7;
            // 
            // lbBetragEinzahlenAuszahlen
            // 
            lbBetragEinzahlenAuszahlen.AutoSize = true;
            lbBetragEinzahlenAuszahlen.Location = new Point(84, 202);
            lbBetragEinzahlenAuszahlen.Name = "lbBetragEinzahlenAuszahlen";
            lbBetragEinzahlenAuszahlen.Size = new Size(47, 15);
            lbBetragEinzahlenAuszahlen.TabIndex = 6;
            lbBetragEinzahlenAuszahlen.Text = "Betrag: ";
            // 
            // btnAuszahlen
            // 
            btnAuszahlen.Location = new Point(137, 223);
            btnAuszahlen.Name = "btnAuszahlen";
            btnAuszahlen.Size = new Size(123, 23);
            btnAuszahlen.TabIndex = 5;
            btnAuszahlen.Text = "Auszahlen";
            btnAuszahlen.UseVisualStyleBackColor = true;
            btnAuszahlen.Click += btnAuszahlen_Click;
            // 
            // btnEinzahlen
            // 
            btnEinzahlen.Location = new Point(8, 223);
            btnEinzahlen.Name = "btnEinzahlen";
            btnEinzahlen.Size = new Size(123, 23);
            btnEinzahlen.TabIndex = 4;
            btnEinzahlen.Text = "Einzahlen";
            btnEinzahlen.UseVisualStyleBackColor = true;
            btnEinzahlen.Click += btnEinzahlen_Click;
            // 
            // btnKontoSelect
            // 
            btnKontoSelect.Location = new Point(266, 363);
            btnKontoSelect.Name = "btnKontoSelect";
            btnKontoSelect.Size = new Size(123, 23);
            btnKontoSelect.TabIndex = 3;
            btnKontoSelect.Text = "Konto Auswahlen";
            btnKontoSelect.UseVisualStyleBackColor = true;
            btnKontoSelect.Click += btnKontoSelect_Click;
            // 
            // btnKontoDelete
            // 
            btnKontoDelete.Location = new Point(137, 363);
            btnKontoDelete.Name = "btnKontoDelete";
            btnKontoDelete.Size = new Size(123, 23);
            btnKontoDelete.TabIndex = 2;
            btnKontoDelete.Text = "Konto Loeschen";
            btnKontoDelete.UseVisualStyleBackColor = true;
            btnKontoDelete.Click += btnKontoDelete_Click;
            // 
            // btnKontoCreate
            // 
            btnKontoCreate.Location = new Point(8, 363);
            btnKontoCreate.Name = "btnKontoCreate";
            btnKontoCreate.Size = new Size(123, 23);
            btnKontoCreate.TabIndex = 1;
            btnKontoCreate.Text = "Konto Erstellen";
            btnKontoCreate.UseVisualStyleBackColor = true;
            btnKontoCreate.Click += btnKontoCreate_Click;
            // 
            // Kontouebersicht
            // 
            Kontouebersicht.FormattingEnabled = true;
            Kontouebersicht.Location = new Point(8, 6);
            Kontouebersicht.Name = "Kontouebersicht";
            Kontouebersicht.Size = new Size(776, 184);
            Kontouebersicht.TabIndex = 0;
            // 
            // kontoAuszug
            // 
            kontoAuszug.Controls.Add(btnTransaktionDetails);
            kontoAuszug.Controls.Add(Transaktionsliste);
            kontoAuszug.Location = new Point(4, 24);
            kontoAuszug.Name = "kontoAuszug";
            kontoAuszug.Padding = new Padding(3);
            kontoAuszug.Size = new Size(792, 393);
            kontoAuszug.TabIndex = 1;
            kontoAuszug.Text = "Konto Auszug";
            kontoAuszug.UseVisualStyleBackColor = true;
            // 
            // btnTransaktionDetails
            // 
            btnTransaktionDetails.Location = new Point(8, 363);
            btnTransaktionDetails.Name = "btnTransaktionDetails";
            btnTransaktionDetails.Size = new Size(123, 23);
            btnTransaktionDetails.TabIndex = 2;
            btnTransaktionDetails.Text = "Details";
            btnTransaktionDetails.UseVisualStyleBackColor = true;
            btnTransaktionDetails.Click += btnTransaktionDetails_Click;
            // 
            // Transaktionsliste
            // 
            Transaktionsliste.FormattingEnabled = true;
            Transaktionsliste.Location = new Point(8, 6);
            Transaktionsliste.Name = "Transaktionsliste";
            Transaktionsliste.Size = new Size(776, 184);
            Transaktionsliste.TabIndex = 0;
            // 
            // kontoUeberweisung
            // 
            kontoUeberweisung.Controls.Add(tbVerwendungszweck);
            kontoUeberweisung.Controls.Add(tbBetrag);
            kontoUeberweisung.Controls.Add(tbIBAN);
            kontoUeberweisung.Controls.Add(btnUeberweisen);
            kontoUeberweisung.Controls.Add(ueberweisungAusfuehrungsdatum);
            kontoUeberweisung.Controls.Add(dtpAusfuehrungsdatum);
            kontoUeberweisung.Controls.Add(cbDauerauftrag);
            kontoUeberweisung.Controls.Add(ueberweisungVerwendungszweck);
            kontoUeberweisung.Controls.Add(ueberweisungBetrag);
            kontoUeberweisung.Controls.Add(ueberweisungIBAN);
            kontoUeberweisung.Controls.Add(ueberweisungEmpfeangerName);
            kontoUeberweisung.Controls.Add(ueberweisungEmpfeanger);
            kontoUeberweisung.Location = new Point(4, 24);
            kontoUeberweisung.Name = "kontoUeberweisung";
            kontoUeberweisung.Padding = new Padding(3);
            kontoUeberweisung.Size = new Size(792, 393);
            kontoUeberweisung.TabIndex = 2;
            kontoUeberweisung.Text = "Ueberweisung";
            kontoUeberweisung.UseVisualStyleBackColor = true;
            // 
            // tbVerwendungszweck
            // 
            tbVerwendungszweck.Location = new Point(236, 142);
            tbVerwendungszweck.Name = "tbVerwendungszweck";
            tbVerwendungszweck.Size = new Size(200, 23);
            tbVerwendungszweck.TabIndex = 11;
            // 
            // tbBetrag
            // 
            tbBetrag.Location = new Point(236, 90);
            tbBetrag.Name = "tbBetrag";
            tbBetrag.Size = new Size(200, 23);
            tbBetrag.TabIndex = 10;
            // 
            // tbIBAN
            // 
            tbIBAN.Location = new Point(236, 55);
            tbIBAN.Name = "tbIBAN";
            tbIBAN.Size = new Size(200, 23);
            tbIBAN.TabIndex = 9;
            tbIBAN.TextChanged += tbIBAN_TextChanged;
            // 
            // btnUeberweisen
            // 
            btnUeberweisen.Location = new Point(8, 363);
            btnUeberweisen.Name = "btnUeberweisen";
            btnUeberweisen.Size = new Size(123, 23);
            btnUeberweisen.TabIndex = 8;
            btnUeberweisen.Text = "Ausfuehren";
            btnUeberweisen.UseVisualStyleBackColor = true;
            btnUeberweisen.Click += btnUeberweisen_Click;
            // 
            // ueberweisungAusfuehrungsdatum
            // 
            ueberweisungAusfuehrungsdatum.AutoSize = true;
            ueberweisungAusfuehrungsdatum.Location = new Point(8, 225);
            ueberweisungAusfuehrungsdatum.Name = "ueberweisungAusfuehrungsdatum";
            ueberweisungAusfuehrungsdatum.Size = new Size(174, 15);
            ueberweisungAusfuehrungsdatum.TabIndex = 7;
            ueberweisungAusfuehrungsdatum.Text = "Ausfuehrungsdatum (optional):";
            // 
            // dtpAusfuehrungsdatum
            // 
            dtpAusfuehrungsdatum.CustomFormat = "dd. MM. yyyy";
            dtpAusfuehrungsdatum.Format = DateTimePickerFormat.Custom;
            dtpAusfuehrungsdatum.Location = new Point(236, 225);
            dtpAusfuehrungsdatum.Name = "dtpAusfuehrungsdatum";
            dtpAusfuehrungsdatum.Size = new Size(200, 23);
            dtpAusfuehrungsdatum.TabIndex = 6;
            // 
            // cbDauerauftrag
            // 
            cbDauerauftrag.AutoSize = true;
            cbDauerauftrag.Location = new Point(8, 180);
            cbDauerauftrag.Name = "cbDauerauftrag";
            cbDauerauftrag.Size = new Size(95, 19);
            cbDauerauftrag.TabIndex = 5;
            cbDauerauftrag.Text = "Dauerauftrag";
            cbDauerauftrag.UseVisualStyleBackColor = true;
            // 
            // ueberweisungVerwendungszweck
            // 
            ueberweisungVerwendungszweck.AutoSize = true;
            ueberweisungVerwendungszweck.Location = new Point(8, 135);
            ueberweisungVerwendungszweck.Name = "ueberweisungVerwendungszweck";
            ueberweisungVerwendungszweck.Size = new Size(165, 15);
            ueberweisungVerwendungszweck.TabIndex = 4;
            ueberweisungVerwendungszweck.Text = "Verwendungszweck (optional)";
            // 
            // ueberweisungBetrag
            // 
            ueberweisungBetrag.AutoSize = true;
            ueberweisungBetrag.Location = new Point(8, 90);
            ueberweisungBetrag.Name = "ueberweisungBetrag";
            ueberweisungBetrag.Size = new Size(47, 15);
            ueberweisungBetrag.TabIndex = 3;
            ueberweisungBetrag.Text = "Betrag: ";
            // 
            // ueberweisungIBAN
            // 
            ueberweisungIBAN.AutoSize = true;
            ueberweisungIBAN.Location = new Point(8, 55);
            ueberweisungIBAN.Name = "ueberweisungIBAN";
            ueberweisungIBAN.Size = new Size(37, 15);
            ueberweisungIBAN.TabIndex = 2;
            ueberweisungIBAN.Text = "IBAN:";
            // 
            // ueberweisungEmpfeangerName
            // 
            ueberweisungEmpfeangerName.AutoSize = true;
            ueberweisungEmpfeangerName.Location = new Point(236, 15);
            ueberweisungEmpfeangerName.Name = "ueberweisungEmpfeangerName";
            ueberweisungEmpfeangerName.Size = new Size(0, 15);
            ueberweisungEmpfeangerName.TabIndex = 1;
            // 
            // ueberweisungEmpfeanger
            // 
            ueberweisungEmpfeanger.AutoSize = true;
            ueberweisungEmpfeanger.Location = new Point(8, 15);
            ueberweisungEmpfeanger.Name = "ueberweisungEmpfeanger";
            ueberweisungEmpfeanger.Size = new Size(77, 15);
            ueberweisungEmpfeanger.TabIndex = 0;
            ueberweisungEmpfeanger.Text = "Empfeanger: ";
            // 
            // kontoDauerauftrag
            // 
            kontoDauerauftrag.Controls.Add(btnDauerauftragLoeschen);
            kontoDauerauftrag.Controls.Add(Dauerauftreage);
            kontoDauerauftrag.Location = new Point(4, 24);
            kontoDauerauftrag.Name = "kontoDauerauftrag";
            kontoDauerauftrag.Padding = new Padding(3);
            kontoDauerauftrag.Size = new Size(792, 393);
            kontoDauerauftrag.TabIndex = 3;
            kontoDauerauftrag.Text = "Dauerauftreage";
            kontoDauerauftrag.UseVisualStyleBackColor = true;
            // 
            // btnDauerauftragLoeschen
            // 
            btnDauerauftragLoeschen.Location = new Point(8, 363);
            btnDauerauftragLoeschen.Name = "btnDauerauftragLoeschen";
            btnDauerauftragLoeschen.Size = new Size(123, 23);
            btnDauerauftragLoeschen.TabIndex = 9;
            btnDauerauftragLoeschen.Text = "Loeschen";
            btnDauerauftragLoeschen.UseVisualStyleBackColor = true;
            btnDauerauftragLoeschen.Click += btnDauerauftragLoeschen_Click;
            // 
            // Dauerauftreage
            // 
            Dauerauftreage.FormattingEnabled = true;
            Dauerauftreage.Location = new Point(8, 6);
            Dauerauftreage.Name = "Dauerauftreage";
            Dauerauftreage.Size = new Size(776, 184);
            Dauerauftreage.TabIndex = 1;
            // 
            // header
            // 
            header.AutoSize = true;
            header.Location = new Point(4, 9);
            header.Name = "header";
            header.Size = new Size(81, 15);
            header.TabIndex = 7;
            header.Text = "Willkommen: ";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(721, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // verwaltungMeldungen
            // 
            verwaltungMeldungen.AutoSize = true;
            verwaltungMeldungen.Location = new Point(270, 5);
            verwaltungMeldungen.Name = "verwaltungMeldungen";
            verwaltungMeldungen.Size = new Size(0, 15);
            verwaltungMeldungen.TabIndex = 9;
            // 
            // KontoPortal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(verwaltungMeldungen);
            Controls.Add(btnLogout);
            Controls.Add(header);
            Controls.Add(kundenPortal);
            Name = "KontoPortal";
            Text = "Kontoverwaltung";
            FormClosing += KontoPortal_FormClosing;
            Load += KontoPortal_Load;
            kundenPortal.ResumeLayout(false);
            kontoDetails.ResumeLayout(false);
            kontoDetails.PerformLayout();
            kontoAuszug.ResumeLayout(false);
            kontoUeberweisung.ResumeLayout(false);
            kontoUeberweisung.PerformLayout();
            kontoDauerauftrag.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label meldungen;
        private TabControl kundenPortal;
        private TabPage kontoUeberweisung;
        private TabPage kontoAuszug;
        private TabPage kontoDetails;
        private Label header;
        private Button btnLogout;
        private Button btnKontoSelect;
        private Button btnKontoDelete;
        private Button btnKontoCreate;
        private ListBox Kontouebersicht;
        private ListBox Transaktionsliste;
        private Button btnTransaktionDetails;
        private Label ueberweisungVerwendungszweck;
        private Label ueberweisungBetrag;
        private Label ueberweisungIBAN;
        private Label ueberweisungEmpfeangerName;
        private Label ueberweisungEmpfeanger;
        private TabPage kontoDauerauftrag;
        private CheckBox cbDauerauftrag;
        private Label ueberweisungAusfuehrungsdatum;
        private DateTimePicker dtpAusfuehrungsdatum;
        private TextBox tbIBAN;
        private Button btnUeberweisen;
        private TextBox tbVerwendungszweck;
        private TextBox tbBetrag;
        private Button btnDauerauftragLoeschen;
        private ListBox Dauerauftreage;
        private Label verwaltungMeldungen;
        private Button btnAuszahlen;
        private Button btnEinzahlen;
        private TextBox tbBetragEinzahlenAuszahlen;
        private Label lbBetragEinzahlenAuszahlen;
    }
}