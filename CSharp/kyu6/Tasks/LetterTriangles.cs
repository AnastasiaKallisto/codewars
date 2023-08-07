using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class LetterTriangles
    {
        public static string Triangle(string row)
        {
            int n = row.Length;
            int c = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(row[i]) - 96;
            }
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    c = arr[j] + arr[j + 1];
                    arr[j] = c > 26 ? c % 26 : c;
                    if (arr[j] == 0)
                        arr[j] = 26;
                    Console.Write(arr[j] + " ");
                }
                Console.WriteLine();

            }
            return "" + Convert.ToChar(arr[0] + 96);
        }
    }
}
