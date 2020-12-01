using System;

namespace LibreriaMCD
{
    public class ClassMCD
    {
        public static int LeggiNumero()
        { 
            Console.WriteLine("inserisci un numero intero");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public static int MaxComuneDivisore(int n1, int n2)
        {
            int r;
            while (n2 != 0)
            {
                r = n1 % n2;
                n1 = n2;
                n2 = r;
            }
            return n1;

        }
        public static void Es3()
        {
            int n;
            int count = 0, numtot = 0;

            do
            {
               n = LeggiNumero();
                if (n != 0)
                    count++;
                numtot++;
            } while (n % 2 == 0);
            Console.WriteLine($"i numeri letti sono {numtot},i numeri diversi da zero sono {count} ");
        }
        public static void Es4()
        {
            int n,countPari = 0, countDispari = 0;
            do
            {
                n = LeggiNumero();
                if (n % 2 == 0)
                    countPari++;
                else
                    countDispari++;
            } while (n!=9999);
            Console.WriteLine($"i numeri pari sono {countPari}, i numeri dispari sono {countDispari-1}");

        }
        public static void Es5(int n)
        {
            int i = 1, count = 0;
            while (i <= n/2)
            {
                if (n % i == 0)
                {
                   
                    count++;
                }
                i++;
            }
            if (count == 1)
                Console.WriteLine("il numero è primo");
            else
                Console.WriteLine("il numero non è primo");

        }
        public static void Es7(int n)
        {
            for(int i = 2; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static int Es10(int n)
        {
            int num;
            
            int min = int.MaxValue;
            for(int i = 0; i < n; i++)
            {
                num = LeggiNumero();
                if (num % 2 != 0)
                    min = Math.Min(min, num);

            }
            return min;
        }
        public static void Es9()
        {
            for(int i = 5; i <= 100; i = i + 5)
            {
                Console.WriteLine(i);
            }
        }
        public static void Es8()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"il quadrato di {i} è {i * i}, il cubo di {i} è {i * i * i} ");
            }
        }
        public static void Es6()
        {
            int n = LeggiNumero();
            for (int i =2; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
