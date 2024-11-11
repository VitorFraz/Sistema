using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class Ex_02
    {
        public void CadInfo2()
        {
            Console.Clear();
            Console.WriteLine("\n 2º Exercicio: Faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5)");

            double nota;

            Console.WriteLine("\nDigite a nota do aluno:");
            nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 7)
            {
                Console.WriteLine("\nAluno aprovado!");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("\nAluno em recuperação!");
            }
            else
            {
                Console.WriteLine("\nAluno reprovado!");
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
