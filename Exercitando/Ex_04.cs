using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class Ex_04
    {
        public void CadInfo4()
        {
            Console.Clear();
            Console.WriteLine("\n4º Exercicio: Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.");

            double numero;

            Console.WriteLine("\nDigite um número:");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("\nO número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("\nO número é negativo.");
            }
            else
            {
                Console.WriteLine("\nO número é zero.");
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
