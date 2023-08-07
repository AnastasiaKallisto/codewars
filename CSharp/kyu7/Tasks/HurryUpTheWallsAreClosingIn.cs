using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class HurryUpTheWallsAreClosingIn
    {
        public static bool CanEscape((int, int)[] walls)
        {
            for(int i = 1; i <= walls.Length; i++)
            {
                if (!(walls[i - 1].Item1 - i > 0 && walls[i-1].Item2 - i > 0))
                    return false;
            }
            return true;
        }
        // интересное решение
        // return walls.Select((x, i) => x.Item1 > i + 1 && x.Item2 > i + 1).All(x => x);

// еще одна конструкция
// return !walls.Where((x, i) => Math.Min(x.Item1, x.Item2) - i < 2).Any();

/* 
 * 5. walls.Select((w, i) => Math.Min(w.Item1, w.Item2) >= i + 2) 
 * - использование метода расширения Select из LINQ 
 * для проекции каждого элемента массива walls на новое значение. 
 * В данном случае происходит сравнение минимального значения 
 * из кортежа с индексом элемента массива (i) плюс 2.
 * 
6. All(w => w) - использование метода расширения All из LINQ 
для проверки, что результаты сравнения в предыдущей конструкции 
истинны для всех элементов массива.
 * */
}
}
