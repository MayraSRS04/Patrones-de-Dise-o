using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Patrones_Disenio.AbstractFactory
{
    internal abstract class Abstract_Factory
    {
        public abstract IAeronave Create_AvionComercial();
        public abstract IAeronave Create_AvionetaPrivada();
        public abstract IAeronave Create_Helicoptero();
        public abstract IAeronave Create_Dron();
    }
}
