using System;

namespace Proyecto_Final_Patrones_Disenio.Proxy
{
    public class ProxySimulador : ISimulador
    {
        private readonly SimuladorReal _real = new SimuladorReal();

        public void Acceder()
        {
            const int maxIntentos = 3;
            int intentos = 0;
            while (intentos < maxIntentos)
            {
                Console.Write("Usuario: ");
                var usuario = Console.ReadLine();
                Console.Write("Contraseña: ");
                var clave = Console.ReadLine();

                if (usuario == "admin" && clave == "1234")
                {
                    Console.WriteLine("[SimuladorReal] Acceso concedido al simulador.\n");
                    _real.Acceder();
                    return;
                }

                intentos++;
                Console.WriteLine($"Credenciales inválidas ({intentos}/{maxIntentos}).\n");
            }

            Console.WriteLine("Demasiados intentos. Saliendo...");
            Environment.Exit(1);
        }
    }
}