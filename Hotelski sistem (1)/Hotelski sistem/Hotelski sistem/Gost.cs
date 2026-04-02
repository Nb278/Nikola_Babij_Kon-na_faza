using System;
using System.Collections.Generic;
using System.Text;

namespace Hotelski_sistem
{
    public class Gost
    {
        // STATIČNI podatek - skupen vsem objektom razreda Gost
        // šteje koliko gostov je trenutno v sistemu
        public static int SteviloGostov = 0;

        // LASTNOSTI - kapsulacija, dostop do zasebnih podatkov
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public int Starost { get; set; }

        // KONSTRUKTOR - ustvari novega gosta in poveča števec
        public Gost(string ime, string priimek, int starost)
        {
            Ime = ime;
            Priimek = priimek;
            Starost = starost;
            SteviloGostov++; // vsak nov gost poveča števec
        }

        // STATIČNA METODA - pokličemo jo brez objekta: Gost.Ustvari(...)
        // Alternativni način ustvarjanja gosta
        public static Gost Ustvari(string ime, string priimek, int starost)
        {
            return new Gost(ime, priimek, starost);
        }

        // Objektna metoda - preverja starost
        public bool JePolnoleten()
        {
            return Starost >= 18;
        }

        // Objektna metoda - vrne polno ime
        public string PolnoIme()
        {
            return $"{Ime} {Priimek}";
        }

        // PREOBLAGANJE OPERATORJA == 
        // Dva gosta sta enaka če imata isto ime in priimek
        public static bool operator ==(Gost a, Gost b)
        {
            if (a is null || b is null) return false;
            return a.Ime == b.Ime && a.Priimek == b.Priimek;
        }

        // Ko preobložimo ==, moramo preobložiti tudi !=
        public static bool operator !=(Gost a, Gost b)
        {
            return !(a == b);
        }

        // Equals in GetHashCode morata biti usklajena z ==
        public override bool Equals(object obj)
        {
            return obj is Gost g && this == g;
        }

        public override int GetHashCode()
        {
            return (Ime + Priimek).GetHashCode();
        }

        // DESTRUKTOR - pokliče se ko objekt zapustí pomnilnik
        ~Gost()
        {
            SteviloGostov--; // zmanjša števec ko gost ni več potreben
        }
    }
}