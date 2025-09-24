using Proyecto_Final_Patrones_Disenio.AbstractFactory;

namespace Proyecto_Final_Patrones_Disenio.Visitor
{
    public interface IVisitanteEstadisticas
    {
        void Visit(IAeronave aeronave);
    }
}
