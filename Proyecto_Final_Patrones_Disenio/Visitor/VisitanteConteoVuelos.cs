using Proyecto_Final_Patrones_Disenio.AbstractFactory;

namespace Proyecto_Final_Patrones_Disenio.Visitor
{
    public class VisitanteConteoVuelos : IVisitanteEstadisticas
    {
        public int TotalVuelos { get; private set; }

        public void Visit(IAeronave aeronave)
        {
            TotalVuelos += aeronave.CantidadVuelos;
        }
    }
}
