using System;

namespace Proyecto_Final_Patrones_Disenio.Proxy
{
    public class SimuladorReal : ISimulador
    {
        public void Acceder()
        {
            Console.WriteLine("[SimuladorReal] Acceso concedido al simulador.");
        }
    }
}
