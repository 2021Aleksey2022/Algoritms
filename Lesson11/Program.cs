using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    /// <summary>
    /// Динамическое и рекрсивное программирование.Какая разница между ними.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Program fb = new Program();
            for(int n = 0; n < 60; n++)
            {
                Console.WriteLine("{0} : {1}", n, fb.Fib_Dynamic(n));
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        public int Fib_Recursive(int n)
        {
            if(n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fib_Recursive(n - 1) + Fib_Recursive(n - 2);
            }
        }
        public int Fib_Dynamic(int n)
        {
            int result;
            int[] fib = new int[n + 1];
            for(int i = 2; i <= n; i++)
            {
                fib[0] = 0;
                fib[1] = 1;
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            result = fib[n];
            return result;
        }
    }
}
