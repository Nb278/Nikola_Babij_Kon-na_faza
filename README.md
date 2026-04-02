# Nikola_Babij_Kon-na_faza[README.md](https://github.com/user-attachments/files/26446982/README.md)
#  Hotelski sistem

Aplikacija za upravljanje rezervacij v hotelskem kompleksu, razvita v C# z grafičnim vmesnikom (Windows Forms).

---

##  Opis projekta

Hotelski sistem omogoča recepcijskemu osebju hitro in enostavno ustvarjanje rezervacij za goste. Gost lahko izbere med različnimi tipi nastanitve, doda parkirišče in sistem samodejno izračuna skupno ceno z upoštevanjem popustov.

### Tipi nastanitve:
- **Navadna soba** – osnovna nastanitev
- **Luksuzna soba** – z možnostjo bazena
- **Hiška** – samostojna enota
- **Šotor** – z možnostjo priključka na elektriko

### Popusti:
- 10% popust pri rezervaciji 3 ali več dni
- 20% popust pri rezervaciji 7 ali več dni

---

## Zahteve sistema

- Windows 10 ali novejši
- Visual Studio 2022 ali novejši
- .NET 8.0 SDK (vključen v Visual Studio)

---

##  Nameščanje in zagon

### 1. Prenos projekta
Odprite ukazno vrstico (CMD) in zaženite:
```
git clone https://github.com/[vaše-uporabniško-ime]/Hotelski-sistem.git
```
ali kliknite gumb **Code → Download ZIP** na tej strani in razpakirajte.

### 2. Odpiranje v Visual Studio
1. Zaženite Visual Studio 2022
2. Kliknite **Open a project or solution**
3. Poiščite mapo projekta in odprite datoteko **Hotelski sistem.sln**

### 3. Zagon
1. Pritisnite **F5** ali kliknite zeleni gumb ▶
2. Odpre se glavno okno aplikacije

---

## Navodila za uporabo

### Ustvarjanje rezervacije:

1. **Vnesite podatke o gostu**
   - Ime in priimek (obvezno)
   - Starost (mora biti 18 ali več)

2. **Izberite tip nastanitve**
   - Navadna soba
   - Luksuzna soba → po želji obkljukajte Bazen
   - Hiška
   - Šotor → po želji obkljukajte Elektrika

3. **Dodajte parkirišče** (neobvezno)
   - Obkljukajte Parkirišče
   - Po želji obkljukajte Pokrito

4. **Nastavite število dni**

5. **Kliknite gumb Rezerviraj**
   - Pojavi se potrditveno sporočilo
   - Rezervacija se doda v seznam na dnu okna
   - V naslovni vrstici se posodobi skupni prihodek

---

##  Struktura projekta

```
Hotelski sistem/
├── Form1.cs               # Glavni grafični vmesnik
├── Nastanitev.cs          # Abstraktni razred za nastanitve
├── Soba.cs                # Navadna soba
├── LuksuznaSoba.cs        # Luksuzna soba z bazenom
├── Hiska.cs               # Hiška
├── Sotor.cs               # Šotor z elektriko
├── Gost.cs                # Razred za gosta
├── Rezervacija.cs         # Razred za rezervacijo
├── HotelskiSistem.cs      # Glavni sistem za upravljanje
├── Parkirisce.cs          # Parkirišče
└── IPlacljivo.cs          # Vmesnik za plačljive storitve
```

---

## OOP koncepti v projektu

| Koncept | Kje je uporabljen |
|---|---|
| Kapsulacija | Zasebni podatki v vseh razredih |
| Dedovanje | Soba, LuksuznaSoba, Hiska, Sotor dedujejo Nastanitev |
| Polimorfizem | Abstraktna metoda IzracunajCeno() |
| Abstraktni razred | Nastanitev |
| Vmesnik | IPlacljivo |
| Indekser | HotelskiSistem[i] |
| Delegati in dogodki | RezervacijaUstvarjena |
| Preoblaganje operatorjev | +, >, < na Rezervacija; ==, != na Gost |
| const / readonly / static | DDV, ImeHotela, SteviloGostov |

---

## Avtor

**[Vaše ime] [Vaš priimek]**  
Šolsko leto: 2025/2026
