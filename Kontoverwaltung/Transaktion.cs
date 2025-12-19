using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Kontoverwaltung
{
    public class Transaktion : IReaddableCSV
    {
        public string Auftraggeber { get; set; } = string.Empty;
        public string Empfaenger { get; set; } = string.Empty;
        public string AuftraggeberIBAN { get; set; } = string.Empty;
        public string EmpfaengerIBAN { get; set; } = string.Empty;
        public string Verwendungszweck { get; set; } = string.Empty;
        public decimal Betrag { get; set; }
        public DateOnly Ausfuehrungsdatum { get; set; }
        public bool Dauerauftrag { get; set; }

        public override string ToString()
        {
            return $"Auftraggeber: {Auftraggeber}       Datum: {Ausfuehrungsdatum}      Verwendungszweck: {Verwendungszweck}            Betrag: {Betrag.ToString()} €";
        }

        public string ToCSV() {
            // Cultureinfo wird Verwendet um die Komata fuer verschiedene Systeme enheitlich zu Speichern
            return $"{Auftraggeber};{AuftraggeberIBAN};{Empfaenger};{AuftraggeberIBAN};{Verwendungszweck};{Betrag.ToString(CultureInfo.InvariantCulture)};{Ausfuehrungsdatum.ToString(CultureInfo.InvariantCulture)};{Dauerauftrag}";
        }
    }
}
