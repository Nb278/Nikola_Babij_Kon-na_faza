using System;
using System.Collections.Generic;
using System.Text;


namespace Hotelski_sistem
{
    // ABSTRAKTNI RAZRED - ne moremo ustvariti objekta Nastanitev direktno
    // Implementira vmesnik IPlacljivo
    // Vse nastanitve (Soba, Hiska...) dedujejo od tega razreda
    public abstract class Nastanitev : IPlacljivo
    {
        // CONST - vrednost se nikoli ne spremeni, enaka za vse objekte
        public const double DDV = 0.22;

        // READONLY - nastavi se samo enkrat v konstruktorju, potem je nespremenljiva
        public readonly int Stevilka;

        // LASTNOST z get in set - kapsulacija
        public double OsnovnaCena { get; set; }

        // KONSTRUKTOR - pokličejo ga podrazredi z base(...)
        protected Nastanitev(int st, double cena)
        {
            Stevilka = st;
            OsnovnaCena = cena;
        }

        // ABSTRAKTNA METODA - vsak podrazred jo mora implementirati po svoje
        // To je POLIMORFIZEM - ista metoda, različno obnašanje
        public abstract double IzracunajCeno();

        // OBJEKTNA metoda - enaka za vse nastanitve
        public string Opis()
        {
            return $"{ToString()} | Osnovna cena: {OsnovnaCena} €";
        }

        // DESTRUKTOR - pokliče se ko objekt ni več potreben
        ~Nastanitev()
        {
            // sprostimo vire če bi jih imeli
        }
    }
}
