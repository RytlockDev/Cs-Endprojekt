using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    static class Config
    {
        // Speichert Zentral alle Dateipfade zum einfachen Aendern
        public static readonly string DATEIPFAD_KUNDEN = @".\Kunden.csv";
        public static readonly string DATEIPFAD_KONTEN = @".\Konten.csv";
        public static readonly string DATEIPFAD_TRANSAKTIONEN = @".\Transaktionen.csv";
    }
}
