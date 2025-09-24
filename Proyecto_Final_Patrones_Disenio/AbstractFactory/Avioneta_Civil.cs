using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_Patrones_Disenio.AbstractFactory;
using Proyecto_Final_Patrones_Disenio.Visitor;

namespace Proyecto_Final_Patrones_Disenio.AbstractFactory
{
    internal class Avioneta_Civil : IAeronave, IVisitableAeronave
    {
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public double CostoVuelo { get; set; }
        public int CantidadVuelos { get; private set; }

        public Avioneta_Civil()
        {
            Fabricante = "Cessna";
            Modelo = "172 Skyhawk";
            Placa = "HC-AVP";
            CostoVuelo = 350;
            CantidadVuelos = 0;
        }

        public void Volar()
        {
            CantidadVuelos++;
            Console.WriteLine($"Avioneta Civil {Placa} realizando vuelo recreativo. Total vuelos: {CantidadVuelos}");
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
