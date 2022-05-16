using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Codigo para la presentación
            string logo = @"   
    _____  _______                   __         ______              ______    __                                                 
   /     |/       \                 /  |       /      \            /      \  /  |                                                
   $$$$$ |$$$$$$$  |  ______    ____$$ |      /$$$$$$  |  ______  /$$$$$$  |_$$ |_    __   __   __   ______    ______    ______  
      $$ |$$ |__$$ | /      \  /    $$ |      $$ \__$$/  /      \ $$ |_ $$// $$   |  /  | /  | /  | /      \  /      \  /      \ 
 __   $$ |$$    $$< /$$$$$$  |/$$$$$$$ |      $$      \ /$$$$$$  |$$   |   $$$$$$/   $$ | $$ | $$ | $$$$$$  |/$$$$$$  |/$$$$$$  |
/  |  $$ |$$$$$$$  |$$ |  $$ |$$ |  $$ |       $$$$$$  |$$ |  $$ |$$$$/      $$ | __ $$ | $$ | $$ | /    $$ |$$ |  $$/ $$    $$ |
$$ \__$$ |$$ |  $$ |$$ \__$$ |$$ \__$$ |      /  \__$$ |$$ \__$$ |$$ |       $$ |/  |$$ \_$$ \_$$ |/$$$$$$$ |$$ |      $$$$$$$$/ 
$$    $$/ $$ |  $$ |$$    $$/ $$    $$ |      $$    $$/ $$    $$/ $$ |       $$  $$/ $$   $$   $$/ $$    $$ |$$ |      $$       |
 $$$$$$/  $$/   $$/  $$$$$$/   $$$$$$$/        $$$$$$/   $$$$$$/  $$/         $$$$/   $$$$$/$$$$/   $$$$$$$/ $$/        $$$$$$$/ 





                                $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                                $$$$$$   Nombre del programador: Jesus Dario Rodriguez     $$$$$$
                                $$$$$$   Matricula: ES1822021661                           $$$$$$
                                $$$$$$   Grupo: DS-DPRN2-2201-B2-001                       $$$$$$
                                $$$$$$   Profesor: Ing.Jacobo Díaz Martínez                $$$$$$
                                $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$



";

            Console.WriteLine(logo);
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            menu();
        }
        static void menu() {
            int aux1 = 1;
            //generando random para seleccion de vacuna     
            Random rnd = new Random();
            int vacunaSeleccionada = rnd.Next(4);
            string menu = @"
            
                               ╔════════════════════════════════════════════════════════╗
                               ║         Seleccione la operación a realizar:            ║
                               ╠════════════════════════════════════════════════════════╢
                               ║    1.- Mi vacuna                                       ║
                               ║                                                        ║
                               ║    2.- Inyectar                                        ║
                               ║                                                        ║
                               ║    0.- Salir                                           ║    
                               ║                                                        ║
                               ╠════════════════════════════════════════════════════════╢
                               ║    Ingrese su seleccion ...                            ║
                               ╚════════════════════════════════════════════════════════╝

";
            while (aux1 != 0) { 
                Console.WriteLine(menu);
                int seleccion = (int)Convert.ToInt32(Console.ReadLine());

                switch (seleccion)
                {
                    case 1:

                        if (vacunaSeleccionada == 1) {
                            Pfizer vacuna1 = new Pfizer("Pfizer", "USA y Alemania", 95, 19, 2, 21, "Efectos");
                            vacuna1.miVacuna();
                        } else if (vacunaSeleccionada == 2) { Cansino vacuna1 = new Cansino("Cansino", "China", 56, 4, 1, 0, "Efectos");

                            vacuna1.miVacuna();
                        }
                        else { SputnikV vacuna1 = new SputnikV("Sputnik V", "Rusia", 92, 10, 2, 21, "efectos");
                            vacuna1.miVacuna();
                        }

                        break;
                    case 2:
                        int aux2 = 1;
                        string menu2 = @"
            
                               ╔════════════════════════════════════════════════════════╗
                               ║         Seleccione la operación a realizar:            ║
                               ╠════════════════════════════════════════════════════════╢
                               ║    1.- Estoy de acuerdo y deseo seguir adelante con el ║ 
                               ║        proceso de vacunación?                          ║
                               ║                                                        ║
                               ║    2.- No estoy de acuerdo y no deseo vacunarme        ║
                               ║                                                        ║
                               ║                                                        ║
                               ╠════════════════════════════════════════════════════════╢
                               ║    Ingrese su seleccion ...                            ║
                               ╚════════════════════════════════════════════════════════╝

";
                        while (aux2 !=0) {
                            Console.WriteLine(menu2);
                            int seleccion2 = (int)Convert.ToInt32(Console.ReadLine());
                            switch (seleccion2) { 
                                case 1:
                                    if (vacunaSeleccionada == 1)
                                    {
                                        Pfizer vacuna1 = new Pfizer("Pfizer", "USA y Alemania", 95, 19, 2, 21, "Efectos");
                                        vacuna1.inyectar();
                                    }
                                    else if (vacunaSeleccionada == 2)
                                    {
                                        Cansino vacuna1 = new Cansino("Cansino", "China", 56, 4, 1, 0, "Efectos");

                                        vacuna1.inyectar();
                                    }
                                    else
                                    {
                                        SputnikV vacuna1 = new SputnikV("Sputnik V", "Rusia", 92, 10, 2, 21, "efectos");
                                        vacuna1.inyectar();
                                    }
                                    aux2 = 0;
                                    break;
                                case 2:
                                    aux2 = 0;
                                    break;
                            
                            }

                        }    

                       

                        break;
                    case 0:
                        aux1 = 0;
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion valida");
                        break;

                }
            }
        }

    }

}
