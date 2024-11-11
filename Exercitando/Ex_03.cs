using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class Ex_03
    {
        public void CadInfo3()
        {
            Console.Clear();
            Console.WriteLine("\n3º Exercicio: Crie um programa que leia a idade de uma pessoa e informe se ela é maior de idade (18 anos ou mais) ou menor de idade.");

            int idade;

            Console.WriteLine("\nDigite a idade da pessoa:");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("\nA pessoa é maior de idade.");
            }
            else
            {
                Console.WriteLine("\nA pessoa é menor de idade.");
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
