using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    internal class Girokonto : Konto
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
    }
}
