using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Kontoverwaltung
{
    static class Datei_IO
    {
        private static string[] parts, lines;
        // Speicher die Listen aus den Klassen.
        // Nutzt Generics um die Methode Uebersichtlich zuhalten
        public static void SchreibeDaten<T>(string pfad, List<T> liste) where T : IReaddableCSV {
            List<string> daten = new List<string>();
            foreach (T t in liste) {
                daten.Add(t.ToCSV());
            }
            File.WriteAllLines(pfad, daten);
        }

        internal static void ErzeugeKonten(string pfad) {
            Kunde geholterKunde = null;

            if (!File.Exists(pfad)) return;

            lines = File.ReadAllLines(pfad);

            foreach (string line in lines) {
                if(string.IsNullOrEmpty(line)) continue;
                parts = line.Split(";");
                foreach(var kunde in Kundenverwaltung.kunden) {
                    if (parts[1].Equals(kunde.LoginName)) {
                        geholterKunde = kunde;
                        break;
                    }
                }

                decimal saldo, extra;

                // Cultureinfo wird Verwendet um die Komata fuer verschiedene Systeme enheitlich zu Speichern
                decimal.TryParse(parts[3], NumberStyles.Any, CultureInfo.InvariantCulture, out saldo);
                decimal.TryParse(parts[4], NumberStyles.Any, CultureInfo.InvariantCulture, out extra);

                if (parts[0].Equals("G")) {
                    Girokonto giro = new Girokonto(geholterKunde, parts[2]);
                    giro.Saldo = saldo;
                    giro.Dispo = extra;
                    Kontoverwaltung.konten.Add(giro);
                }

                if (parts[0].Equals("S")) {
                    Sparkonto spar = new Sparkonto(geholterKunde, parts[2]);
                    spar.Saldo = saldo;
                    spar.Zinssatz = extra;
                    Kontoverwaltung.konten.Add(spar);
                }

            }
        }

        internal static void ErzeugeKunden(string pfad) {
            if (!File.Exists(pfad)) return;

            lines = File.ReadAllLines(pfad);

            foreach (string line in lines) { 
                if(string.IsNullOrEmpty(line)) continue;
                parts = line.Split(";");
                Kundenverwaltung.LegeKundeAn(parts[0], parts[1], parts[2]);
            }
        }

        internal static void ErzeugeTransaktionen(string pfad) {
            if (!File.Exists(pfad)) return;

            lines = File.ReadAllLines(pfad);

            foreach (string line in lines) {
                if (string.IsNullOrEmpty(line)) continue;
                parts = line.Split(";");

                decimal betrag;
                DateOnly datum;

                // Cultureinfo wird Verwendet um die Komata fuer verschiedene Systeme enheitlich zu Speichern
                decimal.TryParse(parts[5], NumberStyles.Any, CultureInfo.InvariantCulture, out betrag);
                DateOnly.TryParse(parts[6], CultureInfo.InvariantCulture, DateTimeStyles.None, out datum);
                bool dauerauftrag = bool.Parse(parts[7]);

                Kontoverwaltung.TransaktionAnlegen(parts[0], parts[1], parts[2], parts[3], parts[4], betrag, datum, dauerauftrag);
            }
        }
    }
}
