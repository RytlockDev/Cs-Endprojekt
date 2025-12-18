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

        private  static Konto SucheKonto(string iban)
        {
            foreach (Konto konto in konten) {
                if(konto.IBAN.Equals(iban)) return konto;
            }
            return null;
        }

        public static void Ueberweisen(decimal betrag,string ursprungskonto, string empfeangerIban)
        {
            var zielkonto = SucheKonto(empfeangerIban);
            var ursprung = SucheKonto(ursprungskonto);
            zielkonto.Einzahlen(betrag);
            ursprung.Auszahlen(betrag);
        }

        public static void TransaktionAnlegen(string ursprungName, 
                                              string ursprungIban, 
                                              string ziel, 
                                              string zielIban, 
                                              string zweck, 
                                              decimal betrag, 
                                              DateOnly date, 
                                              bool dauerauftrag)
        {
            Transaktion transaktion = new Transaktion
            {
                Auftraggeber = ursprungName,
                AuftraggeberIBAN = ursprungIban,
                Empfaenger = ziel,
                EmpfaengerIBAN = ursprungIban,
                Verwendungszweck = zweck,
                Betrag = betrag,
                Ausfuehrungsdatum = date,
                Dauerauftrag = dauerauftrag
            };
            transaktionen.Add(transaktion);
        }
    }
}
