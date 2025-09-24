using Proyecto_Final_Patrones_Disenio.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Patrones_Disenio.Mediator
{
    internal class Drones : IColega
    {
        private IAeronave _dron;

        public Drones(string nombre, IMediator mediador, IAeronave dron)
            : base(nombre, mediador)
        {
            _dron = dron;
        }

        public override void recibirMensaje(string mensaje, IColega emisor)
        {
            Console.WriteLine($"[{Nombre}] recibió {mensaje}");
        }
    }
}
