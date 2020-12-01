using System;
using LibreriaMCD;

namespace Esercizio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il parametro");
            int n = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine(ClassMCD.Es10(n));
            
        }
    }
}
