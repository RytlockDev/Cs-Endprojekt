using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    public class Kunde : IReaddableCSV
    {
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }

        public override string ToString() => $"Name: {Name}";

        public string ToCSV()
        {
            return $"{Name};{LoginName};{Password}";
        }
    }
}
