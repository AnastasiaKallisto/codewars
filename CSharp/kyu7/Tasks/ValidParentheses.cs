using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class ValidParentheses
    {
        public static bool ValidParenthesesF(string str)
        {
            int left = 0, right = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                    left++;
                else right++;
                if (left < right)
                    return false;
            }
            return right == left;
        }
    }
}
