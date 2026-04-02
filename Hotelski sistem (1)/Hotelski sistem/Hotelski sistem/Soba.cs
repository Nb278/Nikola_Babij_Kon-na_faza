using System;
using System.Collections.Generic;
using System.Text;

namespace Hotelski_sistem
{
    // DEDOVANJE - Soba deduje vse od Nastanitev
    public class Soba : Nastanitev
    {
        // Konstruktor pokliče konstruktor starša z base()
        public Soba(int st, double cena) : base(st, cena) { }

        // PREPISOVANJE abstraktne metode - override
        // POLIMORFIZEM - navadna soba računa ceno samo z DDV
        public override double IzracunajCeno()
        {
            return OsnovnaCena * (1 + DDV);
        }

        // Prepisovanje ToString() za lepši izpis
        public override string ToString()
        {
            return $"Navadna soba {Stevilka}";
        }
    }
}