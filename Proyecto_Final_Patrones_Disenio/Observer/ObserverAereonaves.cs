using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Patrones_Disenio.Observer
{
    internal class ObserverAereonaves : IObserver
    {

        private object _aeronave;
        public ObserverAereonaves(object aeronave)
        {
            _aeronave = aeronave;
        }
        public override void actualizar(ISubject sujeto)
        {
            var placaProp = _aeronave.GetType()
                                    .GetProperty("Placa")
                                    ?.GetValue(_aeronave)
                                    ?.ToString()
                                ?? "<sin placa>";

            Console.WriteLine($"[Observer] Aeronave {placaProp} ha recibido alerta.");
        }
    }
}
