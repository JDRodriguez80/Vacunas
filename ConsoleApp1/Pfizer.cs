using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunacion
{
    public class Pfizer : Vacuna
    {

        private int dosis;
        private int timeSpan;
        private string efectos = "efectos secundarios";
        //constructor
        public Pfizer(string nombre, string origen, double efectividad, double costo, int dosis, int timeSpan, string efectos) : base(nombre, origen, efectividad, costo)
        {

            this.dosis = dosis;
        }

        public override void miVacuna()
        {
            string mecanismo = @"               
ARN de la espicula            xxxxxxxxxx
del virus               xxxxxx         xxxxxx                          ┌──────────────────────────┐
    │                xxxx x                  xxx                       │                          │
    │               xx                          xxx                    │  El mensaje se codifica  │
    │             xxx                             xxx                  │  en una molecula de ARN  │
    │             x                           ~~    xxx                │  que se encapsula en una │
    │            x           ~               ~~       xx               │  membrana lipídica para  │
    │           x       ~~~~ ~              ~          xx              │  que pueda entrar en las │
    │          xx       ~  ~~~              ~~  ~~~     x              │  celulas                 │
    │          x        ~~~~~ ~              ~ ~~ ~~     x             │                          │
    └─────────────────►       ~              ~~~~~~~     x             │                          │
               x       ~~~~~~~~               ~           x            │                          │
               x        ~~~~~~                ~    ~~     x            │                          │
               x             ~                 ~~~~ ~~    x            │                          │
               xx      ~~~~~~~                  ~~~~~     x            │                          │
                x      ~~  ~~~~                ~          x            └──────────────────────────┘
                 x      ~~~~  ~                ~         xx
                 x            ~             ~~~~~~~     xx
                  x      ~~~~~~~~ ~~~~~~~~~~    ~~~    xx
                  xx     ~ ~~~  ~~~      ~  ~~~       xx
                   xx    ~~~    ~ ~~     ~    ~      xx ◄────────────  Membrana Lipídica
                    xx          ~~~~      ~~~~~    xxx
                     xxx                        xxx
                        xxxx                xxxxx
                            xxxxxxxxxxxxxxxx";
            Console.WriteLine("La Vacuna que se le aplicara sera:{0}", Nombre);
            Console.WriteLine("\nOrigen:{0}", Origen);
            Console.WriteLine("\nCon una efectividad del {0} %", Efectividad);
            Console.WriteLine("el mecanismo con el que funciona esta vacuna es:\n" + mecanismo);
            Console.WriteLine("\nLa cantidad de dosis para esta vacuna es de:" + dosis);
        }
        public override void inyectar()
        {
            Console.WriteLine("Inyectado con pfizer");
        }
    }
}
