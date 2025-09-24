using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Patrones_Disenio.AbstractFactory
{
    internal class Simulacion_Militar : Abstract_Factory
    {
        public override IAeronave Create_AvionComercial() => new Avion_Militar();
        public override IAeronave Create_AvionetaPrivada() => new Avioneta_Militar();
        public override IAeronave Create_Helicoptero() => new Helicoptero_Militar();
        public override IAeronave Create_Dron() => new Dron_Militar();
    }
}
