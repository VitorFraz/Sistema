using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class Ex_06
    {
        public void CadInfo6()
        {
            Console.Clear();
            Console.WriteLine("\n6º Exercicio: 3. Escreva um programa que verifique se um número fornecido pelo usuário é um múltiplo de outro número fornecido pelo usuário.");

            int numero, divisor;

            Console.WriteLine("Digite um número:");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o divisor:");
            divisor = Convert.ToInt32(Console.ReadLine());

            if (divisor == 0)
            {
                Console.WriteLine("Divisor não pode ser zero.");
            }
            else
            {
                if (numero % divisor == 0)
                {
                    Console.WriteLine($"{numero} é um múltiplo de {divisor}.");
                }
                else
                {
                    Console.WriteLine($"{numero} não é um múltiplo de {divisor}.");
                }
            }
            Thread.Sleep(2000);
            Console.Clear();
            Cabecalho variavelcabecalho = new Cabecalho();
            variavelcabecalho.cabecalho();

            ListaExercicios variavelListaExercicios = new ListaExercicios();
            variavelListaExercicios.listaDeExercicio();
        }
    }
}
