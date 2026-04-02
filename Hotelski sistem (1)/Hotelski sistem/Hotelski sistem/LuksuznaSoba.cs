using System;
using System.Collections.Generic;
using System.Text;

namespace Hotelski_sistem
{
    // DEDOVANJE - LuksuznaSoba deduje od Nastanitev
    public class LuksuznaSoba : Nastanitev
    {
        // Lastnost samo za to vrsto nastanitve
        public bool ImaBazen { get; set; }

        // Konstruktor sprejme dodaten parameter za bazen
        public LuksuznaSoba(int st, double cena, bool bazen) : base(st, cena)
        {
            ImaBazen = bazen;
        }

        // POLIMORFIZEM - luksuzna soba računa ceno drugače kot navadna
        public override double IzracunajCeno()
        {
            // bazen doda 80€, brez bazena doda 30€
            double dodatek = ImaBazen ? 80 : 30;
            return (OsnovnaCena + dodatek) * (1 + DDV);
        }

        public override string ToString()
        {
            return ImaBazen ?
                $"Luksuzna soba {Stevilka} (bazen)" :
                $"Luksuzna soba {Stevilka}";
        }
    }
}