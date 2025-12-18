using System;
using System.Collections.Generic;
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

        public override string ToCSV()
        {
            return $"S;" + base.ToCSV() + $";{Zinssatz}";
        }
    }
}
