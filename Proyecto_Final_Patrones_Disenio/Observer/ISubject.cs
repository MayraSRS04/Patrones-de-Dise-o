using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Patrones_Disenio.Observer
{
    internal abstract class ISubject
    {
        protected List<IObserver> suscriptores = new List<IObserver>();
        public abstract void suscribirse(IObserver observador);
        public abstract void desuscribirse(IObserver observador);
        public abstract void notificar(string codigoAlerta);
    }
}
