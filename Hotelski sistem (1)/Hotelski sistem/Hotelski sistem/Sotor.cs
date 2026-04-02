using System;
using System.Collections.Generic;
using System.Text;

namespace Hotelski_sistem
{
    // DEDOVANJE - Sotor deduje od Nastanitev
    public class Sotor : Nastanitev
    {
        // Lastnost samo za šotor
        public bool Elektrika { get; set; }

        public Sotor(int st, double cena, bool elektrika) : base(st, cena)
        {
            Elektrika = elektrika;
        }

        // POLIMORFIZEM - šotor ima najcenejšo ceno, elektrika doda 5€
        public override double IzracunajCeno()
        {
            double dodatek = Elektrika ? 5 : 0;
            return (OsnovnaCena + dodatek) * (1 + DDV);
        }

        public override string ToString()
        {
            return Elektrika ?
                $"Šotor {Stevilka} (elektrika)" :
                $"Šotor {Stevilka}";
        }
    }
}
