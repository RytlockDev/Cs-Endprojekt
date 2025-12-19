using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kontoverwaltung
{
    public partial class KontoPortal : Form
    {
        private Hauptfenster _Hauptfenster;
        private Kunde _KundeAngemeldet;
        private Konto _Ausgeweahlt;
        private Transaktion _Transaktion;
        public KontoPortal(Hauptfenster mainWin, Kunde benutzer)
        {
            InitializeComponent();
            // Variable von der instanz des Hauptfensters
            _Hauptfenster = mainWin;
            _KundeAngemeldet = benutzer;
        }

        private void KontoPortal_Load(object sender, EventArgs e)
        {
            // Setzt das Fenster an die Gleiche stelle wie das Hauptfenster
            Location = new Point(_Hauptfenster.Location.X, _Hauptfenster.Location.Y);
            header.Text += $" {_KundeAngemeldet.Name}";
            // Lead alle Konten zum Aktuellen Benutzer
            LadeKonten();
            btnEinzahlen.Enabled = false;
            btnAuszahlen.Enabled = false;
        }

        private void KontoPortal_FormClosing(object sender, FormClosingEventArgs e) {}

        // Schreibt vor dem Beenden alle Daten in 3 CSV Dateien
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Datei_IO.SchreibeDaten(Config.DATEIPFAD_KUNDEN, Kundenverwaltung.kunden);
            Datei_IO.SchreibeDaten(Config.DATEIPFAD_KONTEN, Kontoverwaltung.konten);
            Datei_IO.SchreibeDaten(Config.DATEIPFAD_TRANSAKTIONEN, Kontoverwaltung.transaktionen);
            this.Close();
            _Hauptfenster.Show();
        }

        private void btnKontoCreate_Click(object sender, EventArgs e)
        {
            CreateKonto konto = new CreateKonto(_Hauptfenster, _KundeAngemeldet);
            konto.ShowDialog();
            LadeKonten();
        }

        private void btnKontoDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kontouebersicht.SelectedItem == null) throw new ArgumentException("Bitte Konto Auswahlen");
                else Kontoverwaltung.LoescheKonto((Konto)Kontouebersicht.SelectedItem);
                LadeKonten();
                verwaltungMeldungen.ForeColor = Color.Green;
                verwaltungMeldungen.Text = "Konto erfolgreicht Geloescht";
            }
            catch (ArgumentException ae)
            {
                verwaltungMeldungen.ForeColor = Color.Red;
                verwaltungMeldungen.Text = ae.Message;
            }

        }

        private void btnKontoSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kontouebersicht.SelectedItem == null) throw new ArgumentException("Bitte Konto Auswahlen");
                else _Ausgeweahlt = (Konto) Kontouebersicht.SelectedItem;
                LadeAuszug();
                LadeDauerauftreage();
                btnEinzahlen.Enabled = true;
                btnAuszahlen.Enabled = true;
            }
            catch (ArgumentException ae)
            {
                verwaltungMeldungen.ForeColor = Color.Red;
                verwaltungMeldungen.Text = ae.Message;
            }
        }


        private void btnEinzahlen_Click(object sender, EventArgs e)
        {          
            decimal betrag = decimal.Parse(tbBetragEinzahlenAuszahlen.Text);
            _Ausgeweahlt.Einzahlen(betrag);
            Kontoverwaltung.TransaktionAnlegen(_Ausgeweahlt.Inhaber.Name,
                                                   _Ausgeweahlt.IBAN,
                                                   _Ausgeweahlt.Inhaber.Name,
                                                   _Ausgeweahlt.IBAN,
                                                   "Einzahlung",
                                                   betrag,
                                                   DateOnly.FromDateTime(DateTime.Today),
                                                   false);
            LadeKonten();
            LadeAuszug();
            verwaltungMeldungen.ForeColor = Color.Green;
            verwaltungMeldungen.Text = "Betrag eingezahlt";
        }

        private void btnAuszahlen_Click(object sender, EventArgs e)
        {
            try
            {
                decimal betrag = decimal.Parse(tbBetragEinzahlenAuszahlen.Text);
                _Ausgeweahlt.Auszahlen(betrag);
                Kontoverwaltung.TransaktionAnlegen(_Ausgeweahlt.Inhaber.Name,
                                                   _Ausgeweahlt.IBAN,
                                                   _Ausgeweahlt.Inhaber.Name,
                                                   _Ausgeweahlt.IBAN,
                                                   "Auszahlung",
                                                   -betrag,
                                                   DateOnly.FromDateTime(DateTime.Today),
                                                   false);
                LadeKonten();
                LadeAuszug();
            }
            catch (ArgumentException ae)
            {
                verwaltungMeldungen.ForeColor = Color.Red;
                verwaltungMeldungen.Text= ae.Message;
            }
            verwaltungMeldungen.ForeColor = Color.Green;
            verwaltungMeldungen.Text = "Betrag abgehoben";
        }

        private void btnTransaktionDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (Transaktionsliste.SelectedItem == null) throw new ArgumentException("Bitte Transaktion Auswahlen");
                else _Transaktion = (Transaktion)Transaktionsliste.SelectedItem;
                TransaktionsDetails details = new TransaktionsDetails(_Hauptfenster, _Transaktion);
                details.ShowDialog();
            }
            catch (ArgumentException ae)
            {
                verwaltungMeldungen.ForeColor = Color.Red;
                verwaltungMeldungen.Text = ae.Message;
            }
        }

        private void btnUeberweisen_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(tbBetrag.Text) < 0) throw new ArgumentException("Betrag muss goesser 0 sein");

                decimal betrag = decimal.Parse(tbBetrag.Text);
                DateOnly date = DateOnly.FromDateTime(dtpAusfuehrungsdatum.Value);

                Kontoverwaltung.Ueberweisen(betrag, _Ausgeweahlt.IBAN, tbIBAN.Text);
                Kontoverwaltung.TransaktionAnlegen(_Ausgeweahlt.Inhaber.Name,
                                                   _Ausgeweahlt.IBAN,                                                   
                                                   ueberweisungEmpfeangerName.Text,
                                                   tbIBAN.Text,
                                                   tbVerwendungszweck.Text,
                                                   betrag,
                                                   date,
                                                   cbDauerauftrag.Checked);
                LadeKonten();
                LadeAuszug();
                LadeDauerauftreage();
            }
            catch (ArgumentException ae)
            {
                verwaltungMeldungen.ForeColor = Color.Red;
                verwaltungMeldungen.Text = ae.Message;
            }

            verwaltungMeldungen.ForeColor = Color.Green;
            verwaltungMeldungen.Text = "Ueberweisung Ausgefuehrt";
        }

        private void btnDauerauftragLoeschen_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dauerauftreage.SelectedItem == null) throw new ArgumentException("Bitte Dauerauftrag Auswahlen");
                Transaktion delete = (Transaktion)Dauerauftreage.SelectedItem;
                Kontoverwaltung.transaktionen.Remove(delete);
                LadeDauerauftreage();
            }
            catch (ArgumentException ae)
            {
                verwaltungMeldungen.ForeColor = Color.Red;
                verwaltungMeldungen.Text = ae.Message;
            }

            verwaltungMeldungen.ForeColor = Color.Green;
            verwaltungMeldungen.Text = "Dauerauftrag Geloescht";
        }

        // Schaut nach an welche Iban Ueberwiesen wird und sucht dann automatisch den namen
        private void tbIBAN_TextChanged(object sender, EventArgs e)
        {
            string iban = tbIBAN.Text;
            foreach (var konto in Kontoverwaltung.konten)
            {
                if (konto.IBAN.Equals(iban))
                {
                    ueberweisungEmpfeangerName.Text = konto.Inhaber.Name;
                }
                else
                {
                    ueberweisungEmpfeangerName.Text = "";
                }
            }
        }

        // Zeigt alle Konten zum Aktuellen Angemeldeten Benutzer an
        private void LadeKonten()
        {
            Kontouebersicht.Items.Clear();
            foreach (var konten in Kontoverwaltung.konten)
            {
                if (konten.Inhaber.LoginName.Equals(_KundeAngemeldet.LoginName))
                {
                    Kontouebersicht.Items.Add(konten);
                }
            }
        }

        // Zeigt alle Transaktionen zum Aktuellen Angemeldeten Benutzer an
        private void LadeAuszug()
        {
            Transaktionsliste.Items.Clear();
            foreach (var transaktionen in Kontoverwaltung.transaktionen)
            {
                if (transaktionen.AuftraggeberIBAN.Equals(_Ausgeweahlt.IBAN) 
                  || transaktionen.EmpfaengerIBAN.Equals(_Ausgeweahlt.IBAN))
                {
                    Transaktionsliste.Items.Add(transaktionen);
                }
            }
        }

        // Zeigt alle Dauerauftrage zum Aktuellen Angemeldeten Benutzer an
        private void LadeDauerauftreage()
        {
            Dauerauftreage.Items.Clear();
            foreach (var auftreage in Kontoverwaltung.transaktionen)
            {
                if (auftreage.AuftraggeberIBAN.Equals(_Ausgeweahlt.IBAN) && auftreage.Dauerauftrag)
                {
                    Dauerauftreage.Items.Add(auftreage);
                }
            }
        }
    }
}
