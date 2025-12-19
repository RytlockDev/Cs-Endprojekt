using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kontoverwaltung
{
    public partial class TransaktionsDetails : Form
    {
        private Hauptfenster _Hauptfenster;
        private Transaktion _Transaktion;
        public TransaktionsDetails(Hauptfenster hf, Transaktion t)
        {
            InitializeComponent();
            _Hauptfenster = hf;
            _Transaktion = t;
        }

        private void TransaktionsDetails_Load(object sender, EventArgs e)
        {
            Location = new Point(_Hauptfenster.Location.X, _Hauptfenster.Location.Y);
            LadeDetails();
        }

        private void btnTransaktionenClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LadeDetails() {
            lbTransaktionenAuftrageber.Text += _Transaktion.Auftraggeber;
            lbTransaktionenAuftrageberIBAN.Text += _Transaktion.AuftraggeberIBAN;
            lbTransaktionenEmpfeanger.Text += _Transaktion.Empfaenger;
            lbTransaktionenEmpfeangerIBAN.Text += _Transaktion.EmpfaengerIBAN;
            lbTransaktionenVerwendungszweck.Text += _Transaktion.Verwendungszweck;
            lbTransaktionenDatum.Text += _Transaktion.Ausfuehrungsdatum;
            lbTransaktionenBetrag.Text += _Transaktion.Betrag;
        }
    }
}
