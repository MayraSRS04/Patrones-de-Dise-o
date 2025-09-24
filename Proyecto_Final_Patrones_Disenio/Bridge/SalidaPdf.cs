using System;

namespace Proyecto_Final_Patrones_Disenio.Bridge
{
    public class SalidaPdf : IFormatoSalida
    {
        public void Generar(string contenido)
        {
            Console.WriteLine("[PDF]");
            Console.WriteLine(contenido);
        }
    }
}
