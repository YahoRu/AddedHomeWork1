using System;

namespace AddedHomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[,] array = new int[5, 5];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 11);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

            // 4 Задача:

            int tmp = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                tmp += array[i, 1];
            }

            double answerFourthTask = (double)tmp / array.GetLength(0);

            // 1 Задача:

            tmp = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                tmp += array[i, i];
            }

            double answerFirstTask = (double)tmp / array.GetLength(0);

            // 2 Задача: 

            tmp = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                tmp += array[i, (array.GetLength(0) - 1) - i];
            }

            double answerSecondTask = (double)tmp / array.GetLength(0);

            // 3 Задача:

            tmp = 0;

            for (int i = 1; i < array.GetLength(0); i++)
            {
                tmp += array[i, array.GetLength(0) - i];
            }

            double answerThirdTask = (double)tmp / (array.GetLength(0) - 1);

            // Задача 5 (со звездочкой):

            tmp = 0;

            double counter = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = (i % 2 == 0) ? 0 : 1; j < array.GetLength(1); j += 2)
                {
                    tmp += array[i, j];
                    counter++;
                }
            }

            double answ = (double)tmp / counter;

            Console.WriteLine($"Сумма всех закрашеных клеток: {tmp}");
            Console.WriteLine($"Средннее арифметическое всех закрашенных клеток: {answ}");


            // для пустых клеток - меняем местами тернарный оператор: 

            tmp = 0;
            counter = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = (i % 2 == 0) ? 1 : 0; j < array.GetLength(1); j += 2)
                {
                    tmp += array[i, j];
                    counter++;
                }
            }

            answ = 0;
            answ = (double)tmp / counter;

            Console.WriteLine($"Сумма всех НЕзакрашеных клеток: {tmp}");
            Console.WriteLine($"Средннее арифметическое всех НЕзакрашенных клеток: {answ}");

            // Для другой размерности: (Тот же код, он работает для любой размерности)

            Console.WriteLine("Введите число: ");

            int number = 0;

            int.TryParse(Console.ReadLine(), out number);

            int[,] array2 = new int[number, number];

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = rnd.Next(0, 11);
                }
            }

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write($"{array2[i, j]}\t");
                }
                Console.WriteLine();
            }

            tmp = 0;
            counter = 0;

            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = (i % 2 == 0) ? 1 : 0; j < array2.GetLength(1); j += 2)
                {
                    tmp += array2[i, j];
                    counter++;
                }
            }

            answ = 0;
            answ = (double)tmp / counter;

            Console.WriteLine($"Сумма всех НЕзакрашеных клеток: {tmp}");
            Console.WriteLine($"Средннее арифметическое всех НЕзакрашенных клеток: {answ}");
        }
    }
}
