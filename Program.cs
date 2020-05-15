using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite alguma coisa...");

            string frases = Console.ReadLine();
            string educada = frases.Replace("A","@").Replace("e","$").Replace("i","*").Replace("o","&");

            Console.WriteLine(educada);
        }
    }
}
