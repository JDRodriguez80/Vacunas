using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunacion
{
    public class SputnikV:Vacuna
    {
        private int dosis;
        private int timeSpan;
        private string[] efectos = new string[3];
        //constructor
        public SputnikV(string nombre, string origen, double efectividad, double costo, int dosis, int timeSpan, string[] efectos) : base(nombre, origen, efectividad, costo)
        {   
            this.efectos = efectos;
            this.dosis = dosis;

        }
        public override void miVacuna()
        {
            string mecanismo = @"
                                
                                        ┌─────────────────────────────────────┐
                                        │                                     │
                                        │ EL GEN DEL ADENOVIRUS               │
                                        │                                     │
                                        │ SE SUSTRAE Y EN SU LUGAR            │
                                        │                                     │
                                        │ SE INSERTA  UN GEN CON EL CODIGO    │
                                        │                                     │
                                        │ DE LA PROTEINA DE OTRO VIRUS        │
                                        │                                     │
                                        │                                     │
                                        └─────────────────────────────────────┘


                                                   ADN de la espocila
                 *******************               del virus│                     ***
           *******                  *****                │  │                     *****************
        ***                              ***             │  │               *******                *****
      ***        %%%  %%%%                  ***          │  │             ***                           **
     **    eee   % %  %  %   %%%%              **        │  └─────────────────────────►##  ####           **
   **    ee  ee  %%%  %%%%  %% %%                **      │            **   eee        #  ###  ##           **
  **     eee  e   %%  %%%%  % %%                  *      │           **    e ee        ####   ##  ####       *
  *        eeeee%%%%%%    %%%%%   %%%%%%%          *     │          **     eeee################   ## ##       *
 **           e %           %%    %    ◄─────────────────┘         *          e              #### ## #####     *
 *     eeeee ee          *   %%%% %  %%%%          *              **    eee  ee       ***       #######  ##     **
**    ee  eee         ****       %%%%%             *             **     e  eee     ***  **          ###  ##      *
*      eee   e      ***  *         %%e   eee       **           **      eeeee      *     **           ###         *
*            e      *    *           eeee  e        *           *            e     *      *           ##          *
*            e           *           eeeeeee        *          **            e     *      *            #   ee      *
*      eeeeee            *          e               *          *      eeeee ee           **            e eeeee     *
*     e eeeee            *          ee    ee        *          *      ee  eee           **             eeeeee      **
*     eee   ee      **********       eeeee ee       *          *       eeeeee          **              ee           *
*            e                   eeee eeeeeee      *           *            e         **               e            *
**           e                  ee                 *  ┌────────────────► ee e       **      *****      e  eee       *
 *       eeeeeeeeee         eeeeeeeeeee           *   │        *      eeee ee      *********           eeee e       *
 **     ee   e    eeeeee eee    ee    eee◄───────┐*   │        *      eeeeeeee                       eeeeeeee      **
  **    eeeeee eeeeee  eeeee     eeeeeeee       *│    │        *             e                      ee             *
   *          ee    e e    ee                  **│    │        *            eeeeeeee     eeeeee  eeeeeeeee         *
    **        eeeeee  e     ee                ** │    │        **         eeee      eeeee     eee    e   e         *
     **                eeeeee               **   │    │         *         eeee      ee ee    ee ee   eeeee        *
       ***                               ***     │    │         **                  ee ee     eeee              **
          *****                      *****       │    │          ***                 eee                        *
               * ************* ******            │    │            ****                                      ***
                                                 │    │                ********                            ***
                                                 │    │                       ******* ** ****          *****
                                                 │    │                                      **********
                                                 │    │
                                           Genes inactivados de
                                           adenovirus
 

";
            Console.WriteLine("La Vacuna que se le aplicara sera:{0}", Nombre);
            Console.WriteLine("\nOrigen:{0}", Origen);
            Console.WriteLine("\nCon una efectividad del {0} %", Efectividad);
            Console.WriteLine("el mecanismo con el que funciona esta vacuna es:\n" + mecanismo);
            Console.WriteLine("\nLa cantidad de dosis para esta vacuna es de:{0}", dosis);
        }
        public override void inyectar()
        {
            Console.WriteLine("Ha sido inyectado con Sputnik v ");
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
            { Console.WriteLine("los efectos seundarios que podria presentar son los siguientes:"+" "+efectos[i]+"y"+" "+efectos[j]);
            }else{Console.WriteLine("Usted es muy seguro que se contagie de covid de todas maneras");}
            
        }
    }
}
