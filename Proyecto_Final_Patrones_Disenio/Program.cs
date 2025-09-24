using System;
using System.Collections.Generic;
using System.Linq;
using Proyecto_Final_Patrones_Disenio.Proxy;
using Proyecto_Final_Patrones_Disenio.AbstractFactory;
using Proyecto_Final_Patrones_Disenio.Visitor;
using Proyecto_Final_Patrones_Disenio.Bridge;
using Proyecto_Final_Patrones_Disenio.Composite;
using Proyecto_Final_Patrones_Disenio.Observer;
using Proyecto_Final_Patrones_Disenio.Mediator;

namespace Proyecto_Final_Patrones_Disenio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISubject torre = new TorreControl();
            var central = new CentralMando();

            Console.WriteLine("=== SIMULADOR DE AERONAVES ===\n");

            // 1) Proxy: comprobar acceso
            Console.WriteLine("[Proxy] Verificando acceso al simulador...");
            ISimulador simulador = new ProxySimulador();
            simulador.Acceder();
            Console.WriteLine();

            // 2) Abstract Factory: seleccionar perfil
            Console.WriteLine("1) Simulación Civil");
            Console.WriteLine("2) Simulación Militar");
            Console.Write("\nSeleccione (1-2): ");
            var opcion = Console.ReadLine();

            // Nota: tu base es Abstract_Factory con Simulacion_Civil/Simulacion_Militar
            Abstract_Factory fabrica = opcion == "2"
                ? (Abstract_Factory)new Simulacion_Militar()
                : new Simulacion_Civil();

            Console.WriteLine(opcion == "2"
                ? "\n=== SIMULACIÓN MILITAR INICIADA ===\n"
                : "\n=== SIMULACIÓN CIVIL INICIADA ===\n");

            // 3) Crear flota
            var flotaBase = new List<IAeronave>
            {
                fabrica.Create_AvionComercial(),
                fabrica.Create_AvionetaPrivada(),
                fabrica.Create_Helicoptero(),
                fabrica.Create_Dron(),
                fabrica.Create_Dron(),
                fabrica.Create_Dron()
            };

            // 4) Simular vuelos
            Console.WriteLine("=== REALIZANDO VUELOS DE PRUEBA ===\n");
            flotaBase.ForEach(a => a.Volar());

            Console.WriteLine("\n=== SEGUNDO VUELO PARA ALGUNAS AERONAVES ===\n");
            flotaBase[0].Volar();
            flotaBase[3].Volar();
            Console.WriteLine();

            // 5) Visitor + Bridge
            // Filtrar solo los elementos visitables
            var flotaVisitables = flotaBase
                .OfType<IVisitableAeronave>()
                .ToList();

            // Informe de conteo de vuelos (texto)
            var visitaConteo = new VisitanteConteoVuelos();
            var informeTexto = new GeneradorInformes(visitaConteo, new SalidaTexto());
            informeTexto.CrearInforme(flotaVisitables);

            // Informe de costo total (PDF)
            var visitaCosto = new VisitanteCostoVuelos();
            var informePdf = new GeneradorInformes(visitaCosto, new SalidaPdf());
            informePdf.CrearInforme(flotaVisitables);

            Console.WriteLine();

            // 6) Composite: rutas de vuelo
            Console.WriteLine("=== RUTAS DE VUELO ===\n");
            var ruta = new RutaCompuesta();
            ruta.Agregar(new TramoVuelo("Ciudad A", 150m));
            ruta.Agregar(new TramoVuelo("Ciudad B", 200m));
            ruta.Mostrar();

            var dronesReales = flotaBase.Skip(3).Take(3).ToList();

            var c1 = new Drones("Dron-A", central, dronesReales[0]);
            var c2 = new Drones("Dron-B", central, dronesReales[1]);
            var c3 = new Drones("Dron-C", central, dronesReales[2]);

            central.añadirDron(c1);
            central.añadirDron(c2);
            central.añadirDron(c3);

            Console.WriteLine("\nDRON-A manda: “Reasignación de rutas sector Norte”\n");
            c1.mandarMensaje("Reasignación de rutas sector Norte");

            Console.WriteLine("\nDRON-B manda: “Confirmación de patrullaje sector Sur”\n");
            c2.mandarMensaje("Confirmación de patrullaje sector Sur");

            foreach (var aeronave in flotaBase)
            {
                torre.suscribirse(new ObserverAereonaves(aeronave));
            }
            torre.notificar("A1");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
