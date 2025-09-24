using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto_Final_Patrones_Disenio.Observer
{
    internal class TorreControl : ISubject
    {
        public override void suscribirse(IObserver observador)
        {
            if (suscriptores.Contains(observador))
                Console.WriteLine($"ya esta suscrito a la torre de control, no puede volver a hacerlo");
            else
                suscriptores.Add(observador);
        }
        public override void desuscribirse(IObserver observador)
        {
            if (suscriptores.Contains(observador))
                suscriptores.Remove(observador);
            else
                Console.WriteLine($"no esta suscrito a la torre de control");
        }

        public override void notificar(string codigoAlerta)
        {
            if (suscriptores.Count == 0)
                Console.WriteLine("No existen suscriptores para avisarles de las alertas.");
            else
            {
                Console.WriteLine($"SE GENERO UNA ALERTA {codigoAlerta}");
                foreach (var suscriptor in suscriptores)
                {
                    suscriptor.actualizar(this);
                }
            }
        }
    }
}
