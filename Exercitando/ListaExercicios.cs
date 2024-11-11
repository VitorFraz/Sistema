using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercitando
{
    internal class ListaExercicios
    {
        public void listaDeExercicio()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n╔═════════════════╗");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("║ - Exercicio 1   ║");
            Console.WriteLine("║ - Exercicio 2   ║");
            Console.WriteLine("║ - Exercicio 3   ║");
            Console.WriteLine("║ - Exercicio 4   ║");
            Console.WriteLine("║ - Exercicio 5   ║");
            Console.WriteLine("║ - Exercicio 6   ║");
            Console.WriteLine("║ - Sair (0)      ║");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("╚═════════════════╝\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 1:
                    Ex_01 ex_01 = new Ex_01();
                    //nome do arquivo, nome da variável e nova função
                    ex_01.CadInfo();
                    break;


                case 2:
                    Ex_02 ex_02 = new Ex_02(); 
                    ex_02.CadInfo2();
                    break;


                case 3:
                    Ex_03 ex_03 = new Ex_03();
                    ex_03.CadInfo3();
                    break;


                case 4:
                    Ex_04 ex_04 = new Ex_04();
                    ex_04.CadInfo4();
                    break;


                case 5:
                    Ex_05 ex_05 = new Ex_05();
                    ex_05.CadInfo5();
                    break;


                case 6:
                    Ex_06 ex_06 = new Ex_06();
                    ex_06.CadInfo6();
                    break;


                case 0:
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗░
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║░
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║░
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝██╗██╗██╗
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░╚═╝╚═╝╚═╝");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }
        }
    }
}