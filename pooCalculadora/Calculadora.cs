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
        
        public Calculo()
        {
        }

        public string Calcular()
        {

            decimal? result;

            switch (this.op)
            {
                case '+':
                    result = this.valorA + this.valorB;
                    break;

                case '-':
                    result = this.valorA - this.valorB;
                    break;

                case '*':
                    result = this.valorA * this.valorB;
                    break;

                case '/':
                    if (this.valorB != 0)
                        result = this.valorA / this.valorB;
                    else
                        result = null;
                    break;

                default:
                    Console.WriteLine("Ainda não é possivel fazer esta operação");
                    result = null;
                    break;
            }

            return result.HasValue ? result.ToString() : null;
            }


    }
}

