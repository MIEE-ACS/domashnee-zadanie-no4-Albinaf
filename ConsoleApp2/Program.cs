using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //создадим матрицу

                Console.Write("Введите количество строк: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Введите количество столбцов: ");
                int m = int.Parse(Console.ReadLine());

                Console.WriteLine();

                int[,] arr = new int[n, m];

                Random rand = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        arr[i, j] = rand.Next(15);
                    }
                }

                Console.WriteLine("Матрица:");
                Console.WriteLine();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.Write("Введите расстояние сдвига: ");
                int l = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Выберите режим сдвига( 1 - вправо, 2 - вниз ): ");
                int sd = int.Parse(Console.ReadLine());

                Console.WriteLine();

                //Осуществляем сдвиги
                int inew = 0, jnew = 0;
                int g = 0;

                if (sd == 1)
                {
                    Console.WriteLine("Сдвиг вправо:");
                    Console.WriteLine();
                    int nnew = m - l % m;
                    for (int i = 0; i < n; ++i)
                    {
                        inew = i;
                        for (int j = 0; j < m; ++j)
                        {
                            jnew = (j + nnew) % m;
                            Console.Write(arr[inew, jnew] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (sd == 2)
                {
                    Console.WriteLine();

                    Console.WriteLine("Сдвиг вниз:");
                    Console.WriteLine();
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            inew = (i + (l % n)) % n;
                            jnew = (j + (g % m)) % m;
                            Console.Write(arr[inew, jnew] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else Console.WriteLine("Ошибка!");

            }
            catch
            {
                Console.WriteLine("Ошибка! Проверьте правильность введенных данных.");
            }

            Console.ReadKey();
        }
    }
}
