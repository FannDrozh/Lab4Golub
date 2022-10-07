using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 4");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x <= 0)
            {
                x = sinpluscos(x);
            }
            else if(x> 0)
            {
                x = lnmullog(x);
            }
            Console.WriteLine(x);
            Console.ReadKey();
        }
        static double lnmullog(double x)
        {
            double lnlog= Log(x,10)+Log(x,5);
            return lnlog;
        }
        static double sinpluscos(double x)
        {
            double sincos = Pow((Sin(x) + Cos(x)) + Cos(x), 2);
            return sincos;
        }
        static double Pow(double x,double n)
        {
            double a = 1;
            for (int i=0; i<n; i++)
            {
                a *= x;
            }
            return x;
        }
        public static double Sin(double x)
        {
            const int iterations = 30;
            var res = 0d;
            var pow = x;
            var sign = 1;
            for (int i = 0; i < iterations; i++)
            {
                if (i % 2 == 1)
                {
                    res += pow * sign;
                    sign *= -1;
                }
                pow *= x / (i + 1);
            }
            return res;

        }

        public static double Cos(double x)
        {
            x *= Math.PI / 100;
            const int iterations = 30;
            var res = 0d;
            var pow = 1d;
            var sign = 1;
            for(int i = 0; i < iterations; i++)
            {
                if (i%2 == 0)
                {
                    res += pow * sign;
                    sign *= -1;
                }
                pow *= x/(i + 1);
            }
            return res;
        }
        double fact(double n)
        {//Функция вычисления факториала
            double f = 1, b = 2 * n + 1;
            int i;
            for (i = 0; i <= b; i++)
            {
                f = f * i;
                if (i == 0) { f = 1; }
            }
            return f;
        }
        public static double Log(double x, double a)
        {
            double start, end = 0, middle = 0, accuracy = 5;

            while(Pow(a, end) <= x)
            {
                end++;
            }

            start = end - 1;
            if(Pow(a, start) == x)
            {
                return start;
            }
            for (int i = 0; i<accuracy*4;i ++)
            {
                middle = (start + end) / 2;
                if (Pow(a, middle) > x)
                {
                    end = middle;
                }
                else if (Pow(a, middle) < x) 
                {
                    start = middle;
                }
                else if (Pow(a, middle) == x)
                {
                    return start;
                }
            }
            return middle;
        }

    }
}
