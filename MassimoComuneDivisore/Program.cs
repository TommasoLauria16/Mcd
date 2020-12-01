using System;
using LibreriaMCD;

namespace MassimoComuneDivisore
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = ClassMCD.LeggiNumero();
            int n2 = ClassMCD.LeggiNumero();
            int mcd = ClassMCD.MaxComuneDivisore(n1, n2);
            Console.WriteLine(mcd);
        }
    }
}
