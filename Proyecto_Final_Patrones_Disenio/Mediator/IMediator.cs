using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Patrones_Disenio.Mediator
{
    internal interface IMediator
    {
        void enviar(string mensaje, IColega emisor);
    }
}
