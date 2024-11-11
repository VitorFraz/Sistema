using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class Ex_01
    {
        public void CadInfo()
        {
            Console.Clear();
            Console.WriteLine("\n1º Exercicio: Crie um programa que leia três números e determine qual é o maior. ");

            double num1, num2, num3;

            Console.WriteLine("\nDigite o primeiro número:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            num3 = Convert.ToDouble(Console.ReadLine());

            double maior = num1;

            if (num2 > maior)
            {
                maior = num2;
            }

            if (num3 > maior)
            {
                maior = num3;
            }
                { 
                    Console.WriteLine("\nO maior número é: " + maior);
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
