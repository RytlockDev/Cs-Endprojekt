using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    static class Datei_IO
    {
        public static void SchreibeDaten<T>(string pfad, List<T> liste) where T : IReaddableCSV
        {
            List<string> daten = new List<string>();
            foreach (T t in liste) {
                daten.Add(t.ToCSV());
            }
            File.WriteAllLines(pfad, daten);
        }

        internal static void ErzeugeKonten(string pfad)
        {
            throw new NotImplementedException();
        }

        internal static void ErzeugeKunden(string pfad)
        {
            string[] parts;
            if (!File.Exists(pfad)) return;
            string[] lines = File.ReadAllLines(pfad);
            foreach (string line in lines) { 
                if(string.IsNullOrEmpty(line))  continue;
                parts = line.Split(";");
                Kundenverwaltung.LegeKundeAn(parts[0], parts[1], parts[2]);
            }
        }

        internal static void ErzeugeTransaktionen(string pfad)
        {
            throw new NotImplementedException();
        }
    }
}
