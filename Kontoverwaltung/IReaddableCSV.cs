using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    // Interface um beim Speichern der Listen Mit Generics zu arbeiten und die Klassen kompatibel zu machen
    public interface IReaddableCSV
    {
        string ToCSV();
    }
}
