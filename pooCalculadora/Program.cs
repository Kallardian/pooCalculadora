using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pooCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite a expressão matemática com as seguintes opções (+, -, *, /): ");

                string conta = Console.ReadLine();

                //aqui eu uso um solução para remover os numeros e letras, pra ficar só com o sinal
                string sinal = new String(conta.Where(c => (c < '0' || c > '9') && (c < 'a' || c > 'z')).ToArray());

                //aqui crio um array com o primeiro e o segundo número
                string[] valores = conta.Split(sinal.ToCharArray().First());

                Calculo calculo = new Calculo(Convert.ToDecimal(valores[0]), Convert.ToDecimal(valores[1]), sinal.ToCharArray()[0]);

                Console.WriteLine(calculo.Calcular());

            }
        }
    }
}
