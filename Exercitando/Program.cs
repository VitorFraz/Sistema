using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercitando
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cabecalho variavelcabecalho = new Cabecalho();
            variavelcabecalho.cabecalho();

            ListaExercicios variavelListaExercicios = new ListaExercicios();
            variavelListaExercicios.listaDeExercicio();
        }
    }
}