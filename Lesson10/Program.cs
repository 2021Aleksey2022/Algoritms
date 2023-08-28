using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Program
    {
        static void  Main(string[] args)
        {
            Program program = new Program();
            int n;
            Console.Write("Enter length to generate  Permutations: ");
            n = int.Parse(Console.ReadLine());
            if(n > 20)
            {
                Console.WriteLine("Вы ввели слишком большое число");
            }
            else
            {
                Console.WriteLine("Вы велли ноль или отрицательное число");
            }
            int[] buffer = new int[n];
            bool[] used = new bool[n];
            program.Permutations(n, 0, buffer, used);
            Console.ReadLine();
        }
        public void Permutations(int number, int current, int[] buffer, bool[] used)
        {
            if (current == number)
            {
                for(int i = 0; i < number; i++)
                {
                    Console.Write($"{buffer[i]}\t");
                }
            }
            else
            {
                for(int variant = 0; variant < number; variant++)
                {
                    if (!used[variant])
                    {
                        buffer[current] = variant;
                        used[variant] = true;
                        Permutations(number, current + 1, buffer, used);
                        used[variant] = false;
                    }
                }
            }
        }
        
    }
    
}
