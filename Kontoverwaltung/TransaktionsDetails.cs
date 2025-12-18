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
        private Transaktion _Transaktion;
        public TransaktionsDetails(Transaktion t)
        {
            InitializeComponent();
            _Transaktion = t;
        }

        private void TransaktionsDetails_Load(object sender, EventArgs e)
        {
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
