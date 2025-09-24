using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Patrones_Disenio.Mediator
{
    internal abstract class IColega
    {
        public string Nombre { get; set; }
        private IMediator mediador;

        public IColega(string nombre, IMediator mediador)
        {
            Nombre = nombre;
            this.mediador = mediador;
        }

        public void mandarMensaje(string mensaje)
        {
            mediador.enviar(mensaje, this);
        }
        public abstract void recibirMensaje(string mensaje, IColega emisor);
    }
}
