using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    public class Kunde
    {
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public List<Konto> konten = new List<Konto>();

        public override string ToString() => $"Name: {Name}";
    }
}
