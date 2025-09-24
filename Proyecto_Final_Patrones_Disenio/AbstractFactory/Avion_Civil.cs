using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_Patrones_Disenio.AbstractFactory;
using Proyecto_Final_Patrones_Disenio.Visitor;

namespace Proyecto_Final_Patrones_Disenio.AbstractFactory
{
    internal class Avion_Civil : IAeronave, IVisitableAeronave
    {
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public double CostoVuelo { get; set; }
        public int CantidadVuelos { get; private set; }

        public Avion_Civil()
        {
            Fabricante = "Boeing";
            Modelo = "737-800";
            Placa = "HC-CPP";
            CostoVuelo = 15000;
            CantidadVuelos = 0;
        }

        public void Volar()
        {
            CantidadVuelos++;
            Console.WriteLine($"Avión Civil {Placa} realizando vuelo comercial de pasajeros. Total vuelos: {CantidadVuelos}");
        }

        int IAeronave.CantidadVuelos => CantidadVuelos;
        decimal IAeronave.CostoTotalVuelos => (decimal)CostoVuelo * CantidadVuelos;
        void IAeronave.Volar() => Volar();

        public void Accept(IVisitanteEstadisticas visitante)
        {
            visitante.Visit(this);
        }
    }
}
