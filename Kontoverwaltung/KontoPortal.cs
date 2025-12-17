using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kontoverwaltung
{
    public partial class KontoPortal : Form
    {
        private Hauptfenster _Hauptfenster;
        private Kunde _KundeAngemeldet;
        private Konto _Ausgeweahlt;
        public KontoPortal(Hauptfenster mainWin, Kunde benutzer)
        {
            InitializeComponent();
            _Hauptfenster = mainWin;
            _KundeAngemeldet = benutzer;
        }

        private void KontoPortal_Load(object sender, EventArgs e)
        {
            Location = new Point(_Hauptfenster.Location.X, _Hauptfenster.Location.Y);
            header.Text += $" {_KundeAngemeldet.Name}";
            LadeKonten();
        }

        private void KontoPortal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKontoCreate_Click(object sender, EventArgs e)
        {
            CreateKonto konto = new CreateKonto(_KundeAngemeldet);
            konto.ShowDialog();
        }

        private void btnKontoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kontouebersicht.SelectedItem == null) throw new ArgumentException("Bitte Konto Auswahlen");
                else Kontoverwaltung.LoescheKonto((Konto) Kontouebersicht.SelectedItem);
                LadeKonten();
                verwaltungMeldungen.ForeColor = Color.Green;
                verwaltungMeldungen.Text = "Konto erfolgreicht Geloescht";
            }
            catch (ArgumentException ae) {
                verwaltungMeldungen.ForeColor= Color.Red;
                verwaltungMeldungen.Text= ae.Message;
            }

        }

        private void btnKontoSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kontouebersicht.SelectedItem == null) throw new ArgumentException("Bitte Konto Auswahlen");
                else _Ausgeweahlt = (Konto) Kontouebersicht.SelectedItem;
                LadeAuszug();
            }
            catch (ArgumentException ae)
            {
                verwaltungMeldungen.ForeColor = Color.Red;
                verwaltungMeldungen.Text = ae.Message;
            }
        }

        private void btnTransaktionDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnUeberweisen_Click(object sender, EventArgs e)
        {

        }

        private void btnDauerauftragLoeschen_Click(object sender, EventArgs e)
        {

        }

        private void LadeKonten()
        {
            Kontouebersicht.Items.Clear();
            foreach (var konten in Kontoverwaltung.konten) {
                if (konten.Inhaber.LoginName.Equals(_KundeAngemeldet.LoginName)) {
                    Kontouebersicht.Items.Add(konten); 
                }
            }
        }

        private void LadeAuszug()
        {

        }
    }
}
