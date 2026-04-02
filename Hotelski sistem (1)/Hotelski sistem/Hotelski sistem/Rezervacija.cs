using Hotelski_sistem;
using System;
using System.Collections.Generic;
using System.Text;


namespace Hotelski_sistem
{
    // DELEGAT - tip za metode ki sprejmejo Rezervacija in ne vrnejo nič
    public delegate void RezervacijaUstvarjenaHandler(Rezervacija r);

    public class Rezervacija
    {
        // STATIČNI DOGODEK - vsi objekti Rezervacija delijo ta dogodek
        // Ko nastane nova rezervacija, se sproži ta dogodek
        public static event RezervacijaUstvarjenaHandler RezervacijaUstvarjena;

        // READONLY podatki - nastavijo se samo v konstruktorju
        // ne moremo jih spremeniti po ustvaritvi rezervacije
        public readonly Gost Gost;
        public readonly Nastanitev Nastanitev;
        public readonly int StDni;

        // Lastnost za parkirišče
        public Parkirisce Parkirisce { get; }

        // KONSTRUKTOR - ustvari rezervacijo in sproži dogodek
        public Rezervacija(Gost gost, Nastanitev nastanitev,
                           int dni, Parkirisce park = null)
        {
            Gost = gost;
            Nastanitev = nastanitev;
            StDni = dni;
            Parkirisce = park;

            // Sproži dogodek - obvesti vse naročnike da je nastala rezervacija
            // ?. pomeni: sproži samo če ima kdo naročen ta dogodek
            RezervacijaUstvarjena?.Invoke(this);
        }

        // Izračuna skupno ceno z morebitnim popustom
        public double SkupnaCena()
        {
            double cena = Nastanitev.IzracunajCeno() * StDni;

            // Dodamo parkirišče če ga ima
            if (Parkirisce != null)
                cena += Parkirisce.IzracunajCeno() * StDni;

            // Popust glede na število dni
            if (StDni >= 7)
                cena *= 0.8;      // 20% popust za 7+ dni
            else if (StDni >= 3)
                cena *= 0.9;      // 10% popust za 3-6 dni

            return cena;
        }

        // Vrne besedilni opis rezervacije za izpis v listbox
        public string Izpis()
        {
            return $"{Gost.PolnoIme()} | {Nastanitev} | " +
                   $"{StDni} dni | {SkupnaCena():0.00} €";
        }

        // PREOBLAGANJE OPERATORJA + 
        // Sešteje skupni ceni dveh rezervacij
        // Primer: double skupaj = rezervacija1 + rezervacija2;
        public static double operator +(Rezervacija a, Rezervacija b)
        {
            return a.SkupnaCena() + b.SkupnaCena();
        }

        // PREOBLAGANJE > in < za primerjavo rezervacij po ceni
        public static bool operator >(Rezervacija a, Rezervacija b)
        {
            return a.SkupnaCena() > b.SkupnaCena();
        }

        public static bool operator <(Rezervacija a, Rezervacija b)
        {
            return a.SkupnaCena() < b.SkupnaCena();
        }
    }
}

