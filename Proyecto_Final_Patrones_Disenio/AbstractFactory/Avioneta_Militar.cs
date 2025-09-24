using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_Patrones_Disenio.AbstractFactory;
using Proyecto_Final_Patrones_Disenio.Visitor;

namespace Proyecto_Final_Patrones_Disenio.AbstractFactory
{
    internal class Avioneta_Militar : IAeronave, IVisitableAeronave
    {
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public double CostoVuelo { get; set; }
        public int CantidadVuelos { get; private set; }

        public Avioneta_Militar()
        {
            Fabricante = "Beechcraft";
            Modelo = "T-6 Texan II";
            Placa = "FAE-T601";
            CostoVuelo = 750;
            CantidadVuelos = 0;
        }

        public void Volar()
        {
            CantidadVuelos++;
            Console.WriteLine($"Avioneta Militar {Placa} realizando vuelo de entrenamiento táctico. Total vuelos: {CantidadVuelos}");
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
