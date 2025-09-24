using Proyecto_Final_Patrones_Disenio.AbstractFactory;

namespace Proyecto_Final_Patrones_Disenio.Visitor
{
    public class VisitanteCostoVuelos : IVisitanteEstadisticas
    {
        public decimal CostoTotal { get; private set; }

        public void Visit(IAeronave aeronave)
        {
            CostoTotal += aeronave.CostoTotalVuelos;
        }
    }
}
