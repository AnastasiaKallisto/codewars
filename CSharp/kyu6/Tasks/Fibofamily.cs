using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Fibofamily
    {
        public static int GG(long n)
        {
            // P(n) mod 9 если P(0) = 7, P(1) = 31
            // 7 +1 = 8 = 2^3
            // 31 + 1 = 32 = 2^5
            // будем смотреть на степени двойки
            // Теорема Эйлера: если a и m взаимно просты, то 
            // a ^ (phi (m)) тождественно равна 1
            // phi(m) - функция Эйлера, количество чисел, меньших чем m и взаимно-простых с m чисел
            if (n == 0)
            {
                return 7;
            }
            if (n == 1)
            {
                return 31 % 9;
            }

            BigInteger c = (BigInteger)((Math.Pow(((1 + Math.Sqrt(5)) * 0.5), n + 4) -
                Math.Pow((1 - Math.Sqrt(5)) * 0.5, n + 4)) / Math.Sqrt(5));
            int c1 = (int) c % 6;
            switch (c1)
            {
                case 0: return 1 - 1;
                case 1: return 2 - 1;
                case 2: return 4 - 1;
                case 3: return 8 - 1;
                case 4: return 7 - 1;
                case 5: return 5 - 1;
            }
            return -1;
        }
        public static int G(long n)
        {
            // P(n) mod 9 если P(0) = 7, P(1) = 31
            // 7 +1 = 8 = 2^3
            // 31 + 1 = 32 = 2^5
            // будем смотреть на степени двойки
            // Теорема Эйлера: если a и m взаимно просты, то 
            // a ^ (phi (m)) тождественно равна 1
            // phi(m) - функция Эйлера, количество чисел, меньших чем m и взаимно-простых с m чисел
            // для числа 9 функция Эйлера равна 6
            if (n == 0)
            {
                return 7;
            }
            if (n == 1)
            {
                return 4;// 31%9
            }
            long period = PisanoPeriod(3, 5, 6); // 6 это период повторения остатков у степеней двойки
            long newN = n % period;
            int a = 3;
            int b = 5;
            int c = 0;
            for (int i = 2; i <= newN; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            c %= 6;
            switch (c)
            {
                case 0: return 1 - 1;
                case 1: return 2 - 1;
                case 2: return 4 - 1;
                case 3: return 8 - 1;
                case 4: return 7 - 1;
                case 5: return 5 - 1;
            }
            return -1;
        }

        public static long PisanoPeriod(long f0, long f1, int k)
        {
            long a = f0;
            long b = f1;

            long period = 0;
            long previous = 0;
            while (true)
            {
                long current = (a + b) % k;
                a = b;
                b = current;
                period++;

                if (current == f0 && previous == f1)
                {
                    return period - 1;
                }

                previous = current;
            }
        }
    }
}
