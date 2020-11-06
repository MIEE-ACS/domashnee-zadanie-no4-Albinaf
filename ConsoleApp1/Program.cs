using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //исхoдный массив

            try
            {
                Console.WriteLine("Введите размерность массива: ");
                int n = int.Parse(Console.ReadLine());


                double[] arr = new double[n];

                Console.Write("Исходный массив: ");

                Random rand = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = (10 + 1 + 10) * rand.NextDouble() - 10;
                }

                string output = "";

                foreach (int a in arr)
                {
                    output += $"{a} ";
                }

                Console.WriteLine(output);




                //количество элементов в диапазоне от А до В

                int number = 0;

                Console.WriteLine();

                Console.WriteLine("Выберите диапазон");

                Console.WriteLine("Введите А: ");
                double A = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите В: ");
                double B = double.Parse(Console.ReadLine());

                if (A > B)
                {
                    Console.WriteLine("Ошибка. А не должнобыть больше В.");
                }
                else
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] >= A && arr[i] <= B)
                        {
                            number++;
                        }
                    }


                    Console.WriteLine();
                    Console.WriteLine($"Количество элементов в данном диапазоне = {number}");

                    Console.WriteLine();
                }


                Console.WriteLine();


                //сумма элементов массива, расположенных после максимального элемента

                //найдем максимальный элемент 

                double max = arr[0];
                double sum = 0;
                int i_max = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        i_max = i;
                    }
                }

                Console.WriteLine($"Максимальный элемент массива = {Math.Round(max, 3)} с индексом {i_max}");

                //посчитаем сумму

                for (int i = i_max + 1; i < arr.Length; i++)
                {
                    sum = sum + arr[i];
                }
                Console.WriteLine($"Сумма элементов, стоящих после максимального: {Math.Round(sum, 3)}");




                //упорядочим элементы массива по убыванию модулей

                Console.WriteLine();

                Console.WriteLine("Массив с элементами, убывающими по модулю:");

                double t = arr[0];

                for (int i = 0; i < arr.Length; ++i)
                {

                    for (int j = i; j < arr.Length; j++)
                    {
                        if (Math.Abs(arr[j]) > Math.Abs(arr[i]))
                        {
                            double temp = arr[i];

                            arr[i] = arr[j];

                            arr[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < arr.Length; ++i)
                {

                    for (int j = i; j < arr.Length; j++)
                    {
                        if (Math.Abs(arr[j]) > Math.Abs(arr[i]))
                        {
                            double temp = arr[i];

                            arr[i] = arr[j];

                            arr[j] = temp;
                        }
                    }

                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{Math.Round(arr[i], 3)} ");
                }

            }

            catch(Exception)
            {
                Console.WriteLine("Ошибка! Проверьте правильность введённых данных.");

            }

            Console.ReadKey();

            }
    }
}
