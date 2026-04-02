using System;
using System.Collections.Generic;
using System.Text;

namespace Hotelski_sistem
{
    // Razred za parkirišče - implementira IPlacljivo vmesnik
    public class Parkirisce : IPlacljivo
    {
        // Lastnost - pokrito ali odprto parkirišče
        public bool Pokrito { get; set; }

        public Parkirisce(bool pokrito)
        {
            Pokrito = pokrito;
        }

        // Implementacija vmesnika IPlacljivo
        // Pokrito parkirišče je dražje (15€) kot odprto (8€)
        public double IzracunajCeno()
        {
            return Pokrito ? 15 : 8;
        }

        public override string ToString()
        {
            return Pokrito ? "Pokrito parkirišče" : "Parkirišče";
        }
    }
}