using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Kontoverwaltung
{
    public class Sparkonto : Konto
    {
        private decimal zinssatz;

        public Sparkonto(Kunde inhaber, string iban) : base(inhaber, iban)
        {
            zinssatz = 1.45M;
        }

        public decimal Zinssatz { get => zinssatz; set => zinssatz = value; }

        public override string ToString()
        {
            return "Sparkonto   " + base.ToString();
        }

        // Cultureinfo wird Verwendet um die Komata fuer verschiedene Systeme enheitlich zu Speichern
        public override string ToCSV() {return $"S;" + base.ToCSV() + $";{Zinssatz.ToString(CultureInfo.InvariantCulture)}";}
    }
}
