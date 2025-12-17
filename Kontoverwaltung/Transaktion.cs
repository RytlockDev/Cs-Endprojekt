using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    internal class Transaktion
    {
        public string Auftraggeber { get; set; } = string.Empty;
        public string Empfaenger { get; set; } = string.Empty;
        public string AuftraggeberIBAN { get; set; } = string.Empty;
        public string EmpfaengerIBAN { get; set; } = string.Empty;
        public string Verwendungszweck { get; set; } = string.Empty;
        public decimal Betrag { get; set; }
        public DateOnly Ausfuehrungsdatum { get; set; }
        public bool Dauerauftrag { get; set; }
    }
}
