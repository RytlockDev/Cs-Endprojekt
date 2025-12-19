using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Kontoverwaltung
{
    public class Girokonto : Konto
    {
        private decimal dispo;

        public Girokonto(Kunde inhaber, string iban) : base(inhaber, iban)
        {
            Dispo = 100M;   
        }

        public decimal Dispo { get => dispo; set => dispo = value; }

        public override string ToString()
        {
            return "Girokonto   " + base.ToString();
        }

        public override void Auszahlen(decimal betrag)
        {
            if (this.Dispo + base.Saldo < betrag) throw new ArgumentException("Nicht genug Saldo vorhanden");
            base.Saldo -= betrag;
        }

        // Cultureinfo wird Verwendet um die Komata fuer verschiedene Systeme enheitlich zu Speichern
        public override string ToCSV() {return $"G;" + base.ToCSV() + $";{Dispo.ToString(CultureInfo.InvariantCulture)}"; }
    }
}
