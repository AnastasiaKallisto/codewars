using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class LatinSquares
    {
        public static int[][] MakeLatinSquare(int n)
        {
            int[][] latinSquare = new int[n][];
            for (int i = 0; i < n; i++)
            {
                latinSquare[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    latinSquare[i][j] = (i + j)%n + 1;
                }
            }
            int[] buf;
            int index1, index2, bufElem;
            Random rand = new Random();
            for (int i = 0; i < rand.Next(1,n); i++)
            {
                index1 = rand.Next(n);
                index2 = (index1 + rand.Next(n))%n;
                buf = latinSquare[index2];
                latinSquare[index2] = latinSquare[index1];
                latinSquare[index1] = buf;

                index1 = rand.Next(n);
                index2 = (index1 + rand.Next(n)) % n;
                for (int j = 0; j < n; j++)
                {
                    bufElem = latinSquare[j][index1];
                    latinSquare[j][index1] = latinSquare[j][index2];
                    latinSquare[j][index2] = bufElem;
                }
            }
            

            return latinSquare;
        }
    }
}
