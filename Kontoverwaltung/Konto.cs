using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    public class Konto
    {
        private Kunde inhaber;
        private string  iban;
        private decimal saldo;

        public Konto(Kunde inhaber, string iban)
        {
            Inhaber = inhaber;
            IBAN = iban;
            Saldo = 0M;
        }

        public Kunde Inhaber { get => inhaber; set => inhaber = value; }
        public string IBAN { get => iban; set {if (value.Length < 12) throw new ArgumentException("IBAN zu kurtz");
                                               iban = value; } }
        public decimal Saldo { get => saldo; set => saldo = value; }

        public override string ToString()
        {
            return $"IBAN: {IBAN}           Saldo: {saldo} €";
        }
    }
}
