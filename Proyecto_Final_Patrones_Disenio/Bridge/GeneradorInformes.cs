using System;
using System.Collections.Generic;
using Proyecto_Final_Patrones_Disenio.AbstractFactory;
using Proyecto_Final_Patrones_Disenio.Visitor;

namespace Proyecto_Final_Patrones_Disenio.Bridge
{
    public class GeneradorInformes
    {
        private readonly IVisitanteEstadisticas _visitante;
        private readonly IFormatoSalida _formato;

        public GeneradorInformes(IVisitanteEstadisticas visitante, IFormatoSalida formato)
        {
            _visitante = visitante;
            _formato = formato;
        }

        // Ahora recibe IVisitableAeronave
        public void CrearInforme(IEnumerable<IVisitableAeronave> flota)
        {
            foreach (var aeronave in flota)
                aeronave.Accept(_visitante);

            // … resto idéntico …
            string contenido = (_visitante is VisitanteConteoVuelos vc)
                ? $"Total vuelos: {vc.TotalVuelos}"
                : (_visitante is VisitanteCostoVuelos cc)
                    ? $"Costo total: {cc.CostoTotal:C}"
                    : "Sin datos";

            _formato.Generar(contenido);
        }
    }
}

