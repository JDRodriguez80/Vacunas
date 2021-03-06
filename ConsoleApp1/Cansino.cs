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
        private string [] efectos = new string[3];
        
        //constructor
        public Cansino(string nombre, string origen, double efectividad, double costo, int dosis, int timeSpan, string[] efectos) : base(nombre, origen, efectividad, costo)
        {
            this.efectos = efectos;
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
            Console.WriteLine("Esta vacuna es de una sola dosis por lo que no se requiere una segunda cita de vacunacion");
            
        }
        public void secundarios()
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();
            int efecto = rnd2.Next(100);
            int i = rnd1.Next(2);
            int j = rnd3.Next(2);
           
            
           if (efecto <= Efectividad)
            { Console.WriteLine("los efectos seundarios que podria presentar son los siguientes:"+efectos[i]+"y"+" "+efectos[j]);
            }else{Console.WriteLine("Usted es muy seguro que se contagie de covid de todas maneras");}
            
        }
    }

}

