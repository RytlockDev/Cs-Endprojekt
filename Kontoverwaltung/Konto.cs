using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    public class Konto : IReaddableCSV
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

        public override  string ToString()
        {
            return $"IBAN: {IBAN}           Saldo: {saldo} €";
        }

        public void Einzahlen(decimal betrag)
        {
            this.Saldo += betrag;
        }

        public virtual void  Auszahlen(decimal betrag)
        {
            if(this.Saldo < betrag) throw new ArgumentException("Nicht genug Slado vorhanden");
            this.Saldo -= betrag;
        }
        public virtual string ToCSV()
        {
            return $"{Inhaber.LoginName};{IBAN};{Saldo}";
        }
    }
}
