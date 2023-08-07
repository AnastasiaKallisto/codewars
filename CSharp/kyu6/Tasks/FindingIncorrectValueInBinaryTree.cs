using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class FindingIncorrectValueInBinaryTree
    {
        public static (int, int) FindIncorrectNumber(int[] tree)
        {   // Return a tuple containing the index of
            // the incorrect node and the value that it should be changed to. 
            int n = tree.Length;
            for (int i = 1; i <= n; i++)
            {
                if (tree[i - 1] != tree[2 * i - 1] + tree[2 * i])
                {
                    // надо сначала проверить, не лист ли это
                    Console.WriteLine("n = " + n + " 4*i = " + 4 * i);
                    if (n >= 4 * i)
                    {
                        // если это не лист, проверяем следующие ветки
                        if (tree[2 * i - 1] != tree[4 * i - 1] + tree[4 * i])
                        {
                            return (2 * i - 1, tree[4 * i - 1] + tree[4 * i]);
                        }
                        if (tree[2 * i] != tree[4 * i + 1] + tree[4 * i + 2])
                        {
                            return (2 * i, tree[4 * i + 1] + tree[4 * i + 2]);
                        }
                        return (i - 1, tree[2 * i - 1] + tree[2 * i]);
                    }
                    else
                        return (2 * i, tree[i - 1] - tree[2 * i - 1]);
                }
            }
            return (-1, -1);
        }
    }
}
