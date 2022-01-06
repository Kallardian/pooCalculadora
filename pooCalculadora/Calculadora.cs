using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculadora
{
    public class Calculo
    {
        public decimal valorA { get; set; }
        public decimal valorB { get; set; }

        public char op { get; set; }

        public Calculo(decimal a, decimal b, char operador)
        {
            this.valorA = a;
            this.valorB = b;
            this.op = operador;
        }

        public decimal Calcular(Calculo a)
        {

        }
    }
}
