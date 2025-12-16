using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    public class Konto
    {
        public string Inhaber {  get; set; }
        public string IBAN { get; set; }
        public decimal Saldo { get; set; }
    }
}
