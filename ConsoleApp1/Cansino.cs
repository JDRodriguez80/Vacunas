using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunacion
{
    public class Cansino:Vacuna
    {
        private int dosis;
        private int timeSpan;
        private string efectos = "efectos secundarios";
        //constructor
        public Cansino(string nombre, string origen, double efectividad, double costo, int dosis, int timeSpan, string efectos) : base(nombre, origen, efectividad, costo)
        {

            this.dosis = dosis;
        }
        public override void miVacuna()
        {
            string mecanismo = @"
                                
┌──────────────────────────┐
│                          │                  Modificado para entregar
│  Utiliza un virus        │                  material genetico
│  inofensivo no           │                       │
│  relacionado (vector)    │                       │
│  para entregar el        │                       │
│  material genetico       │                       │
│                          │                       │
│                          │                       │
│                          │             @@@@@@@@@@│
│                          │       @@@@@@@        @│@@@@@@@
│                          │     @@@@@             │       @@@@@@
└──────────────────────────┘ @@@@@                 │            @@@@
                           @@@                     │               @@@
                         @@@                       │                 @@@
                       @@@                  @@@    ▼                   @@@
                     @@@         xx         @ @  @@@@    @@              @@
                    @@         xxxxx        @@@  @  @  @@ @@              @@
                   @@          x   xx@@@@@@@@@@@@@@@@   @  @               @@
                  @@           xxxxxxxx@@         @@     @@@                @@
                 @@                 x               @@@@@@@@                 @@
                @@        xxxxxxx   x                      @@@@@@             @
                @         x     xxxxx                       x                  @
               @@         xxxxxxxx x                        x                  @
               @                   x                        xx    xxxx         @@
               @                  xx                         xx xxx  xx         @
               @          xxxx  xx                            xxx   xxxx        @
               @        xxx   xxx                             xxxxxxx           @
               @        xxxxxxx xx                            x                @
               @                 xx                           xx               @
               @                  xx                       xxxxxxxxxxxx        @
               @@           xxx    x                     xxx    x     xx       @
                @        xxx   xxxx                      x       xx   xx      @@
                @        x       xxxx                 xxxx        xxxx        @
                @@       xx     xx  xx          xxxxxxx  xxxx                @@
                 @        xxxxxx     xxxxxxxxxxxx        x  xxx             @@
                  @            ▲    xxxx     xx xx       xx   xx           @@
                  @@           │  xx   x     x    x       xxxxxx          @@
                    @@         │  xx   x     x    xx                     @@
                     @@@@      │   xxxxx      xx  xx                   @@
                        @@@@   │               xxxx                  @@@
                           @@@@│@                                 @@@@
                               │@@@@@@@@                   @@@@@@@@
                               │       @@@@@@@@@@@@@@@@@@@@@
                               │
                               │
                               │
                               │
                  Genes inactiv│dos
                  Del adenovirus
 
";
            Console.WriteLine("La Vacuna que se le aplicara sera:{0}", Nombre);
            Console.WriteLine("\nOrigen:{0}", Origen);
            Console.WriteLine("\nCon una efectividad del {0} %", Efectividad);
            Console.WriteLine("el mecanismo con el que funciona esta vacuna es:\n" + mecanismo);
            Console.WriteLine("\nLa cantidad de dosis para esta vacuna es de:{0}", dosis);
        }
        public override void inyectar()
        {
            Console.WriteLine("Inyectado con Cansino ");
            Console.WriteLine("En esta vacuna la forma en la que actua en su cuerpo serala siguiente:");
            Console.WriteLine("e");
            
        }
    }

}

