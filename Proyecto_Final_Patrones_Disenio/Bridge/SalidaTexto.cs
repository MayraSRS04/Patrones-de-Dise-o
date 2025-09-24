using System;

namespace Proyecto_Final_Patrones_Disenio.Bridge
{
    public class SalidaTexto : IFormatoSalida
    {
        public void Generar(string contenido)
        {
            Console.WriteLine("[TEXTO]");
            Console.WriteLine(contenido);
        }
    }
}
