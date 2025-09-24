using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Patrones_Disenio.Mediator
{
    internal class CentralMando : IMediator
    {
        private List<IColega> colegas;

        public CentralMando()
        {
            colegas = new List<IColega>();
        }

        public void añadirDron(IColega colega)
        {
            if (colegas.Contains(colega))
                Console.WriteLine($"El Dron ya está suscrito");
            else
                colegas.Add(colega);
        }
        public void eliminarDron(IColega colega)
        {
            if (colegas.Contains(colega))
                colegas.Remove(colega);
            else
                Console.WriteLine($"El Dron ya no está suscrito.");
        }
        public void enviar(string mensaje, IColega emisor)
        {
            if (colegas.Count == 0)
                Console.WriteLine("No existen drones suscritos!");
            else
            {
                foreach (var c in colegas)
                {
                    if (c != emisor)
                        c.recibirMensaje(mensaje, emisor);
                }
            }
        }
    }
}
