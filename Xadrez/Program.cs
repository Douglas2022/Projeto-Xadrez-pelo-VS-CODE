using System;
using tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Console.WriteLine(tab.linhas);
            Console.WriteLine(tab.colunas);
        }
    }
}