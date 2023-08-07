using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class SecondSymbol
    {
        public static int SecondSymbolF(string str, char symbol)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                {
                    count++;
                    if (count == 2)
                        return i;
                }
            }
            return -1;
        }
    }
}
