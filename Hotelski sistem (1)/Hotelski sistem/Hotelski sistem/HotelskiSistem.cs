using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Hotelski_sistem
{
    public class HotelskiSistem
    {
        // Zasebni seznam rezervacij - KAPSULACIJA
        private List<Rezervacija> rezervacije = new List<Rezervacija>();

        // STATIČNI READONLY podatek - ime hotela se ne spreminja
        // static = skupen vsem objektom
        // readonly = ne moremo ga spremeniti po inicializaciji
        public static readonly string ImeHotela = "Hotel Slovenija";

        // Javna lastnost samo za branje - skrije dejanski seznam
        public IReadOnlyList<Rezervacija> Rezervacije => rezervacije;

        // INDEKSER - dostopamo do rezervacije kot sistem[0], sistem[1]...
        // To je podobno kot pri seznamu ali tabeli
        public Rezervacija this[int i]
        {
            get
            {
                // Preverimo da indeks ni izven meja
                if (i < 0 || i >= rezervacije.Count)
                    throw new IndexOutOfRangeException("Napačen indeks rezervacije!");
                return rezervacije[i];
            }
        }

        // Doda novo rezervacijo v seznam
        public void DodajRezervacijo(Rezervacija r)
        {
            rezervacije.Add(r);
        }

        // Izračuna skupni prihodek vseh rezervacij
        public double SkupniPrihodek()
        {
            return rezervacije.Sum(r => r.SkupnaCena());
        }

        // STATIČNA METODA - pokličemo jo brez objekta: HotelskiSistem.Pozdrav()
        public static string Pozdrav()
        {
            return $"Dobrodošli v {ImeHotela}!";
        }

        // DELEGAT za filtriranje rezervacij
        public delegate bool FilterRezervacij(Rezervacija r);

        // Metoda ki sprejme delegat kot parameter in vrne filtrirane rezervacije
        // Primer: Filtriraj(r => r.StDni >= 7) vrne vse rezervacije 7+ dni
        public List<Rezervacija> Filtriraj(FilterRezervacij filter)
        {
            return rezervacije.Where(r => filter(r)).ToList();
        }
    }
}