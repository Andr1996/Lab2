using System;

namespace Lab2Ex3
{
    class Program
    {
      //Ex. 3 Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati o si afisati-i rezultatul.
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul: ");
            int number;
            number = int.Parse(Console.ReadLine());

            if (Divizibil(number))
                Console.WriteLine("Numarul {0} este prim", number);
            else
                Console.WriteLine("Numarul {0} nu este prim", number);
        }

        static bool Divizibil(int div)
        
        {
            int i = 2;
            bool prime = true;
            while (i <= div / 2)
            {
                
                if (div % i == 0)
                    prime = false;
                i += 1;
            }
            return prime;
        }
    }
}
