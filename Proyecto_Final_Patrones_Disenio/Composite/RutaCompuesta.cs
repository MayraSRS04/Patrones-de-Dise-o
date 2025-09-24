using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_Final_Patrones_Disenio.Composite
{
    public class RutaCompuesta : IRuta
    {
        private readonly List<IRuta> _componentes = new List<IRuta>();

        public void Agregar(IRuta tramo)
        {
            _componentes.Add(tramo);
        }

        public decimal ObtenerCosto()
        {
            return _componentes.Sum(r => r.ObtenerCosto());
        }

        public void Mostrar()
        {
            Console.WriteLine("Ruta compuesta:");
            foreach (var r in _componentes)
                r.Mostrar();
            Console.WriteLine($"Costo total: {ObtenerCosto():C}");
        }
    }
}
