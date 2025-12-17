using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    internal static class Kontoverwaltung
    {
        public static List<Konto> konten = new List<Konto>();
        public static List<Transaktion> transaktionen = new List<Transaktion>();
        
        public static void GirokontoAnlegen(Kunde kunde, string iban)
        {
            Girokonto konto = new Girokonto(kunde, iban);
            konten.Add(konto);
        }

        public static void SparkontoAnlegen(Kunde kunde, string iban)
        {
            Sparkonto konto = new Sparkonto(kunde, iban);
            konten.Add(konto);
        }

        public static void LoescheKonto(Konto konto) {
            konten.Remove(konto);
        }
    }
}
