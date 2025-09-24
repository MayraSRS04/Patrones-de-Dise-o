using System;

namespace Proyecto_Final_Patrones_Disenio.Composite
{
    public class TramoVuelo : IRuta
    {
        public string Destino { get; }
        public decimal Precio { get; }

        public TramoVuelo(string destino, decimal precio)
        {
            Destino = destino;
            Precio = precio;
        }

        public decimal ObtenerCosto() => Precio;

        public void Mostrar()
        {
            Console.WriteLine($"Tramo a {Destino}: {Precio:C}");
        }
    }
}
