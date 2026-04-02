using System;
using System.Collections.Generic;
using System.Text;

namespace Hotelski_sistem
{
    // VMESNIK (interface) - določa pogodbo: vsak razred ki implementira
    // ta vmesnik, MORA imeti metodo IzracunajCeno()
    public interface IPlacljivo
    {
        double IzracunajCeno();
    }
}

