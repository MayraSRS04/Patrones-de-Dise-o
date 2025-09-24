using System;

namespace Proyecto_Final_Patrones_Disenio.AbstractFactory
{
    public interface IAeronave
    {
        void Volar();

        int CantidadVuelos { get; }

        decimal CostoTotalVuelos { get; }
    }
}