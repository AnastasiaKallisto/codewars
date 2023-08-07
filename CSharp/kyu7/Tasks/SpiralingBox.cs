using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class SpiralingBox
    {
        public static void Main()
        {
            CreateBox(8, 5);
        }
        public static int[,] CreateBox(int m, int n)
        {
            int[,] answer = new int[n, m];
            int quantity = (int)Math.Ceiling(Math.Min(m, n) / 2.0);
            for (int k = 1; k <= quantity; k++)
            {
                for (int i = k - 1; i <= n - k; i++)
                {
                    answer[i, k - 1] = k;
                    answer[i, m - k] = k;
                }
                for (int j = k - 1; j <= m - k; j++)
                {
                    answer[k - 1, j] = k;
                    answer[n - k, j] = k;
                }
            }
            return answer;
        }
        /*
        var result = new int[length, width];
        for (var i = 0; i < length; i++)
        {
            for (var j = 0; j < width; j++)
            {
                result[i, j] = new[] { i + 1, j + 1, length - i, width - j }.Min();
            }
        }
        return result;
         */
    }
}
