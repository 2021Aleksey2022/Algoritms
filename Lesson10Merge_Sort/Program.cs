using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10Merge_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Program program = new Program();
            program.InputArray(a[n], n);
            program.MergeSort(a[n], n);
            program.PrintArray(a[n], n);
        }
        public void MergeSort(int array, int arraySize)
        {
            //Базовый корпус.Крайне важно внедрить его!!!
            if (arraySize <= 1) return;

            int middle = arraySize / 2;
            int[] left = new int[array];
            int[] right = new int [array + middle];

            //Остерегаться!!!.Используя адресную арифметику : указатель + число дает начало смещенному массиву
            int leftSize = middle;
            int rightSize = arraySize - leftSize;

            //Рекурсия идет туда:
            MergeSort(left[array], leftSize);
            MergeSort(right[array + middle], rightSize);

            //Объедините эти две уже отсортированные части массива:
            int[] buffer = new int[arraySize];
            int left_i = 0;
            int right_i = 0;
            int buffer_i = 0;
            while(left_i < leftSize && right_i < rightSize)
            {
                if(left[left_i] <= right[right_i])
                {
                    //Берем меньшее значение из левой части массива.
                    buffer[buffer_i] = left[left_i];
                    left_i++;
                    buffer_i++;
                }
                else
                {
                    //Берем меньшее значение из правой части массива.
                    buffer[buffer_i] = right[right_i];
                    right_i++;
                    buffer_i++;
                }               
            }
            //Копирование левых элементов с левого размера (если что-то осталось).
            while(left_i < leftSize)
            {
                buffer[buffer_i] = left[left_i];
                left_i++;
                buffer_i++;
            }
            //Копирование правых элементов с правого размера (если что-то осталось).
            while (right_i < rightSize)
            {
                buffer[buffer_i] = right[right_i];
                right_i++;
                buffer_i++;
            }
            //Копирование из буфера в исходный массив.
            int[] arrays = new int[array];
            for (int i = 0; i < arraySize; i++)
            {               
                arrays[i] = buffer[i];
            }
        }
        public void InputArray(int a, int n)
        {
            for(int i = 0; i < n; i++)
            {
                n = int.Parse(Console.ReadLine());
                
            }
        }
        public void PrintArray(int a, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
