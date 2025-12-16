using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    internal static class Kundenverwaltung
    {
        public static List<Kunde> Kunden = new List<Kunde>();

        public static void LegeKundeAn(string username, string loginname, string password) {
            Kunde kunde = new Kunde { Name = username, LoginName = loginname, Password = password };
            Kunden.Add(kunde);
        }
        public static Kunde UserIsAuthorized(string loginnmame, string password) {
            foreach (var kunde in Kunden) {
                if(kunde.LoginName.Equals(loginnmame) && kunde.Password.Equals(password)) return kunde;
            }
            return null;
        }
    }
}
