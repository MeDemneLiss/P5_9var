using System;

namespace pract5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Введите размер массивов:");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (number < 1 || number > 10)
                {
                    Console.WriteLine("Необходимо ввести целое число от 1 до 10");
                }
                else
                {
                    Method(number);
                }
            }
            catch
            {
                Console.WriteLine("Необходимо ввести целое число от 1 до 10");
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        public static void Method(int number)
        {
            if (number < 1 || number > 10)
            {
                Console.WriteLine("Необходимо ввести целое число от 1 до 10");
            }
            else
            {
                Random rnd = new Random();
                int[,] matr1 = new int[number, number];
                int[,] matr2 = new int[number, number];

                int counter1 = 0;

                int answer1 = 0;
                Console.WriteLine("1 массив:");
                for (int i = 0; i < number; i++)
                {
                    counter1 = 0;
                    for (int j = 0; j < number; j++)
                    {
                        int x = rnd.Next(0,9);
                        if (j == 1|| j==3||j==5||j==7||j==9)
                        {
                            counter1+= x;
                        }
                        matr1[i, j] = x;
                        Console.Write(matr1[i, j] + " ");
                    }
                    if (counter1 > 0)
                    {
                        answer1++;
                    }
                    Console.WriteLine("\n");
                    counter1 = 0;
                }
                if (answer1>0) Console.WriteLine($"Кол-во строк первой матрицы сумма нечетных элементов которых дает положительный результат: {answer1}");
                else Console.WriteLine("Ни в одной из строк матрицы сумма нечетных элементов не дает положительный результпт!");
                int counter2 = 0;
                int answer2 = 0;
                Console.WriteLine("2 массив:");
                for (int i = 0; i < number; i++)
                {
                    counter2 = 0;
                    for (int j = 0; j < number; j++)
                    {
                        int x = rnd.Next(0, 9);
                        if (j == 1 || j == 3 || j == 5 || j == 7 || j == 9)
                        {
                            counter2 += x;
                        }
                        matr2[i, j] = x;
                        Console.Write(matr2[i, j] + " ");

                    }
                    if (counter2 > 0)
                    {
                        answer2++;
                    }
                    Console.WriteLine("\n");
                    counter2 = 0;
                }
                if (answer2 > 0) Console.WriteLine($"Кол-во строк во второй матрице сумма нечетных элементов которых дает положительный результат: {answer2}");
                else Console.WriteLine("Ни в одной из строк массива сумма нечетных элементов не дает положительный результпт!");
            }
        }
    }
}