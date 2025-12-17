using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kontoverwaltung
{
    public partial class CreateKonto : Form
    {
        private Kunde _Kunde;
        public CreateKonto(Kunde kunde)
        {
            InitializeComponent();
            _Kunde = kunde;
        }

        private void CreateKonto_Load(object sender, EventArgs e)
        {
            lbInhaber.Text = _Kunde.Name;
        }

        private void CreateKonto_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string iban;
                if (tfBAN.Text.Length < 8) throw new ArgumentException("IBAN muss 8 Zeichen Beinhalten");
                iban = ibanVorkennung + tfBAN.Text;
                if (!cbGiro.Checked && !cbSparkonto.Checked) throw new ArgumentException("Bitte eine Kontoart Weahlen");
                if (cbGiro.Checked)
                {
                    Kontoverwaltung.GirokontoAnlegen(_Kunde, iban);
                }
                else if (cbSparkonto.Checked)
                {
                    Kontoverwaltung.SparkontoAnlegen(_Kunde, iban);
                }

                meldungen.ForeColor = Color.Green;
                meldungen.Text = "Konto erfolgreich erstellt";
                meldungen.Refresh();

                Thread.Sleep(1000);
                this.Close();
            }
            catch(ArgumentException ae) {
                meldungen.ForeColor = Color.Red;
                meldungen.Text = ae.Message;
            }

        }

        private void btnCreateKontoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
