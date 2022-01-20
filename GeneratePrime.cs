using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA25_GeneRandomPrimes_Robin
{
    class GeneratePrime
    {
        public Random rand = new Random();

        public bool DeterminePrime(int number)
        {
            if (number == 0 || number == 1)
                return false;
            for (int i = 2; i < Math.Ceiling(Math.Sqrt(number)); i++)
                if (number % i == 0)
                    return false;
            return true;
        }

        public int Primes()
        {
            int number;
            //Random r = new Random();  //generate same number
            number = rand.Next();
            while (!DeterminePrime(number))
                number++;
            Console.Write($"{number}  ");
            return number;
        }

        public List<int> Primes(int n)
        {
            List<int> primelist = new List<int>();
            for (int i = 0; i < n; i++)
                primelist.Add(Primes());
            return primelist;
        }

        public List<int> Primes(int a, int b)  //a<=b
        {
            List<int> primelist = new List<int>();
            int numcount = 0;
            for (int i = a; i <= b; i++)
                if (DeterminePrime(i))
                {
                    numcount++;
                    primelist.Add(i);
                    if(numcount%10 == 0)
                        Console.Write($"{i}  \n");
                    else Console.Write($"{i}  ");
                }
            if(primelist.Count == 0)
                Console.WriteLine($"There is NO prime between {a} and {b}");
            return primelist;
        }

        public void Primes(int c, int a, int b)
        {
            int numcount = 0;
            List<int> primelist = new List<int>();
            primelist = Primes(a, b);
            int count = primelist.Count;
            if (count > c)
                primelist.RemoveRange(c, count - c);
            else c = count;
            for(int i=0; i<c; i++)
            {
                if (numcount++ == 0) Console.WriteLine($"\nThe first {c} exsit prime(s) is: ");
                if(numcount%10 == 0)
                    Console.Write($"{primelist[i]}  \n");
                else Console.Write($"{primelist[i]}  ");
            }
        }
    }
}
