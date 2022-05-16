using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacunacion
{
    public abstract class Vacuna
    {
        private string nombre;
        private string origen;
        private double efectividad;
        private double costo;

        public Vacuna(string nombre, string origen, double efectividad, double costo)
        {
            this.Nombre = nombre;
            this.Origen = origen;
            this.Efectividad = efectividad;
            this.Costo = costo;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Origen { get => origen; set => origen = value; }
        public double Efectividad { get => efectividad; set => efectividad = value; }
        public double Costo { get => costo; set => costo = value; }

        public virtual void miVacuna()
        {
            //método polimórfico
        }
        public virtual void inyectar() { 
            //método polimórfico
        }
    }
   
}