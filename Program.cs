using System;
using System.ComponentModel;

namespace PPS_lab2._1
{
    class Program
    {
        static double f(double x, int M)
        {
            double summ = 0.5;

            for (int m = 1; m < M; m++ )
            {
                summ += (Math.Pow(-1, m + 1 ) + 1.0) / (Math.PI * m) * Math.Sin(m * x);
            }
            
            return summ;
        }

        static void Main(string[] args)
        {
            double maxRazn = 0;
            double tochZnach;
            double y = 0;

            Console.WriteLine("Введите m: ");
            int m = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Значения функции при различных x: ");
            for (double i = 0; i <= 2.1 * Math.PI; i += Math.PI / 6.0)
            {
                Console.Write(String.Format("x = {0:N15}     |     f(x) = ", i));
                Console.WriteLine(f(i,m));
            }

            for (double i = Math.PI/6.0; i < 5.0*Math.PI/6.0; i += Math.PI / m) {
                y = f(i,m);
                if (Math.Abs(1 - y) > maxRazn)
                    maxRazn = Math.Abs(1 - y);
                y = 0;
            }

            Console.WriteLine("Максимальная разность между значениями функции f(x): " + maxRazn);
        }
    }
}