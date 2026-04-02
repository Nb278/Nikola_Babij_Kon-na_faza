using System;
using System.Collections.Generic;
using System.Text;

namespace Hotelski_sistem
{
    // DEDOVANJE - Hiska deduje od Nastanitev
    public class Hiska : Nastanitev
    {
        public Hiska(int st, double cena) : base(st, cena) { }

        // POLIMORFIZEM - hiška ima fiksni dodatek 40€
        public override double IzracunajCeno()
        {
            return (OsnovnaCena + 40) * (1 + DDV);
        }

        public override string ToString()
        {
            return $"Hiška {Stevilka}";
        }
    }
}