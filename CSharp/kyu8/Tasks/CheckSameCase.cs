using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class CheckSameCase
    {
        /*
         If either of the characters is not a letter, return -1
If both characters are the same case, return 1
If both characters are letters, but not the same case, return 0
        */
        public static int SameCase(char a, char b) => 
            Char.IsLetter(a) && Char.IsLetter(b) ?
            Char.IsLower(a) ?
            Char.IsLower(b) ? 1 : 0 :
            Char.IsLower(b) ? 0 : 1 
            : -1;
        // то что про 0 1 и можно было заменить char.IsLower(a) == char.IsLower(b) ? 1 : 0; 
    }
}
