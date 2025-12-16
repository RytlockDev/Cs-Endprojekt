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
        public KontoPortal(Hauptfenster mainWin, Kunde benutzer)
        {
            InitializeComponent();
            _Hauptfenster = mainWin;
            _KundeAngemeldet = benutzer;
        }

        private void KontoPortal_Load(object sender, EventArgs e)
        {
            Location = new Point(_Hauptfenster.Location.X, _Hauptfenster.Location.Y);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
