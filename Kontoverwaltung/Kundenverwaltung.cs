using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    internal static class Kundenverwaltung
    {
        public static List<Kunde> Kunden = new List<Kunde>();

        public static void LegeKundeAn(string username, string loginname, string password)
        {
            Kunde kunde = new Kunde { Name = username, LoginName = loginname, Password = password };
            Kunden.Add(kunde);
        }
    }
}
