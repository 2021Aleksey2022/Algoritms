using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmC__
{
    static class Program
    {
        const int Max_Binary_Digits_To_Generate = 100;
        static int[] digits_combination = new int[Max_Binary_Digits_To_Generate];
        static int top = 0;

        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите число: ");
            n = int.Parse(Console.ReadLine());
            Program.Generate_BInary_Numbers(n);
            //Console.Write($"{n}");

            Console.ReadLine();
        }
        //Алгоритм Евклида
        static public int Gcd(int a, int b)
        {
            
            return (b == 0) ? a : Gcd(b, a % b);
            
        }
       static public void EuclidsAlgorithm()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            //Program program = new Program();
            //Console.WriteLine(program.Gcd(a, b));
        }
        
        //Ханойские башни.
       static public void HanoiTowers(int i, int k, int n)
        {
            if(n == 1)
            {
                Console.WriteLine($"Move disk 1 from pin {i} to pin {k}");
            }
            else
            {
                int tmp = 6 - i - k;  //third pin(temporary).
                HanoiTowers(i, tmp, n - 1);
                Console.WriteLine($"Move disk {n} from pin {i} to pin {k}");
                HanoiTowers(tmp, k, n - 1);
            }
        }

        //Ломбинаторные объекты - генерация
        static public void Generate_BInary_Numbers(int digits_left_to_generate)
        {
            if (digits_left_to_generate == 0)  // base case
            {
                for(int i = 0; i < top; i++)
                {
                    Console.Write(digits_combination[i]);
                }
                Console.Write("\n");
            }  
            else  //recursive case
            {
                digits_combination[top++] = 1;
                Generate_BInary_Numbers(digits_left_to_generate - 1);
                top--;

                digits_combination[top++] = 0;
                Generate_BInary_Numbers(digits_left_to_generate - 1);
                top--;
            }
        }
    }
}
