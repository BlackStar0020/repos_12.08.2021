using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
           Console.Write("а=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            int summ = 0;
            Console.WriteLine("nechyotnie chisla:");
            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    summ += i;
                    if (i % 2 == 1)
                    {
                        Console.Write($"{i},");
                    }
                }
                Console.WriteLine($"\n summa mezhdu a i b: {summ}\n");

            }
            else Console.WriteLine($"a ne dolzhno bit menshe chem b");




            ///3
            Console.WriteLine("pryamougolnik /n");
            int s = 20, b = 6;
            for (int j = 0; j < b; j++)
            {
                for (int i = 0; i < s; i++)
                {
                    if (j == 0 || j == b - 1) Console.Write("*");
                    else if (i == 0 || i == s - 1) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }




            Console.WriteLine("pryamug triug");
            int i1 = 0, i2 = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (j == i1 || j == i2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                i2 += 3;
            }
            for (int l = 0; l < 21; l++)
            {
                Console.Write("*");
            }


            Console.WriteLine("revnos  treug ");
            int s1 = 9, s2 = 9;
            for (int i = 0; i < 9; i++)

            {
                for (int j = 0; j < 18; j++)

                {
                    if (j == s1 || j == s2) Console.Write("*");

                    else Console.Write(" ");
                }
                Console.Write("\n");
                s1++;
                s2--;
            }
            for (int n = 0; n < 19; n++)

            {
                Console.Write("*");
            }




            Console.WriteLine(" romb ");
            int b1 = 10, b2 = 10;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (j == b1 || j == b2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                b2++;
                b1--;
            }
            int c1 = 0, c2 = 20;
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    if (j == c1 || j == c2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                c1++;
                c2--;
            }
            Console.Write("\n");




           /////4
            double s = 1000;
            Console.Write("P= ");
            double p = Convert.ToDouble(Console.ReadLine());
            double k = 0;
            if (0 < p && p < 25)
            {
                while (true)
                {
                    if (s > 1100)
                    {
                        break;
                    }
                    else
                    {
                        k += 1;
                        s = s + s * p / 100;
                        Console.WriteLine($"posle {k} mesyats = {s}  ");
                    }


                }
            } 
        }
    }
}
