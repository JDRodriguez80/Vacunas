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
        private string[] efectos = new string[3];
        //constructor
        public Pfizer(string nombre, string origen, double efectividad, double costo, int dosis, int timeSpan, string[] efectos) : base(nombre, origen, efectividad, costo)
        {
            this.efectos = efectos;
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
            Console.WriteLine("El periodo minimo para la aplicaciond de una segunda dosis es de 21 dias");
            var datetime = DateTime.Today.AddDays(timeSpan);
            var date = datetime.ToString("dd/MM/yyyy");
            Console.WriteLine("Por lo que la fecha de su segunda dosis el el día:{0}",date );
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
