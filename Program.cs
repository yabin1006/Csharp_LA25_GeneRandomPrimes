using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA25_GeneRandomPrimes_Robin
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratePrime gp = new GeneratePrime();
            Console.WriteLine("Generate Random Primes: ");
            do
            {
                Console.WriteLine("\nGenerate Random Primes commands:\n -prime (Generate a random prime)\n -prime n (Generate n random primes)" +
                    "\n -prime a b (Generate primes: a < primes <b; (a <= b))\n -prime c a b (Generate c primes: a < primes < b; (c>=1, a<=b)" +
                    "\n -exit (Exit menu)");
                Console.Write("Enter command (Above a,b, and c are integer number): ");
                string command = Console.ReadLine().Trim().ToLower();
                while (command.Contains("  "))
                    command = command.Replace("  ", " ");
                string[] strarr = command.Split(' ');

                if (strarr[0] == "exit")
                    break;
                else if (strarr[0] == "prime" && strarr.Length == 1)
                {
                    Console.Write("\nRandom Primes: ");
                    gp.Primes();
                }
                else if(strarr.Length == 2)
                {
                    Console.Write("\nRandom Primes: ");
                    gp.Primes(int.Parse(strarr[1]));
                }
                else if (strarr.Length == 3)
                {
                    Console.Write("\nRandom Primes: ");
                    gp.Primes(int.Parse(strarr[1]), int.Parse(strarr[2]));
                }
                else if (strarr.Length == 4)
                {
                    Console.Write("\nRandom Primes: ");
                    gp.Primes(int.Parse(strarr[1]), int.Parse(strarr[2]), int.Parse(strarr[3]));
                }
                else Console.WriteLine("Entered command is NOT valid, try again.");
            } while (true);
        }
    }
}
