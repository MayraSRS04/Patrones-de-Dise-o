using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Patrones_Disenio.Observer
{
    internal abstract class IObserver
    {
        abstract public void actualizar(ISubject sujeto);
    }
}
