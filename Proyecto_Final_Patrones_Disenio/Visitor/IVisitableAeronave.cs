using Proyecto_Final_Patrones_Disenio.AbstractFactory;

namespace Proyecto_Final_Patrones_Disenio.Visitor
{
    public interface IVisitableAeronave : IAeronave
    {
        void Accept(IVisitanteEstadisticas visitante);
    }
}
