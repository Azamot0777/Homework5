using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("ЗАдание 2");

            // Console.Write("Введите размер массива : ");
            // int mas = int.Parse(Console.ReadLine());
            // int[] counter = new int[mas];
            // int sum = 0, max, min;

            // System.Console.Write(" Элементы массива:");
            // for (int i = 0; i < mas; i++)
            // {
            //     counter[i] = new Random().Next(100);
            //     sum += counter[i];
            //     System.Console.Write($"{counter[i]}\t");
            // }
            // System.Console.WriteLine($"\n  Сумма элементов массива = {sum}");

            // max = counter[0]; min = counter[0];

            // for (int i = 1; i < mas; i++)
            // {
            //     if (counter[i] > max) max = counter[i];
            //     if (counter[i] < min) min = counter[i];
            // }
            // System.Console.WriteLine($"   Минимальное значение:{min}");
            // System.Console.WriteLine($"    Максимальное значение:{max}");

            // System.Console.Write("     Нечетные числа:");
            // for (int i = 0; i < mas; i++)
            // {
            //     if (counter[i] % 2 == 1) System.Console.Write($"{counter[i]}\t");
            // }

            // System.Console.Write("\n      Среднее арифметическое :");
            // System.Console.WriteLine(sum / mas);

            // Сложно было вывести мин и мах значения.


            // System.Console.WriteLine("ЗАдание 3");

            // int[] invers = { 3, 4, 5, 1, 2 };
            // int x = invers.Length;
            // int y = x / 2, shs;

            // System.Console.Write("Массив:");
            // foreach (var i in invers) System.Console.Write($"{i}");

            // for (int i = 0; i < y; i++)
            // {
            //     shs = invers[i];
            //     invers[i] = invers[x - i - 1];
            //     invers[x - i - 1] = shs;
            // }
            // System.Console.Write("\n    Обратный массив:");
            // foreach (var i in invers) System.Console.Write($"{i}");

            // Не понял логику задачи.Подсмотрел с инета.




            // Console.WriteLine("ЗАдаНие 4");

            // Console.Write("     Введите размер массива:");

            // int n = int.Parse(Console.ReadLine());
            // int[] perem = new int[n];

            // System.Console.Write("      Элементы массива :");

            // for (int i = 0; i < n; i++)
            // {
            //     perem[i] = new Random().Next(10);
            //     System.Console.Write($"{perem[i]}\t");
            // }

            // System.Console.Write("\ncount :");
            // int count = int.Parse(Console.ReadLine());
            // System.Console.Write("index :");
            // int index = int.Parse(Console.ReadLine());
            // int[] perem2 = new int[count];

            // for (int i = 0; i < count; i++)
            // {
            //     if (index > n - 1) perem2[i] = 1;
            //     else perem2[i] = perem[index];
            //     index++;
            // }
            // System.Console.Write("Новый массив:");
            // for (int i = 0; i < perem2.Length; i++)
            // {
            //     System.Console.Write($"{perem2[i]}\t");
            // }

            Console.ReadKey();



        }
    }
}
