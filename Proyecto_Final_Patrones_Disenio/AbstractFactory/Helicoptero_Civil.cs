using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_Patrones_Disenio.AbstractFactory;
using Proyecto_Final_Patrones_Disenio.Visitor;

namespace Proyecto_Final_Patrones_Disenio.AbstractFactory
{
    internal class Helicoptero_Civil : IAeronave, IVisitableAeronave
    {
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public double CostoVuelo { get; set; }
        public int CantidadVuelos { get; private set; }

        public Helicoptero_Civil()
        {
            Fabricante = "Bell";
            Modelo = "407";
            Placa = "HC-CHE";
            CostoVuelo = 2500;
            CantidadVuelos = 0;
        }

        public void Volar()
        {
            CantidadVuelos++;
            Console.WriteLine($"Helicóptero Civil {Placa} realizando vuelo de transporte ejecutivo. Total vuelos: {CantidadVuelos}");
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
