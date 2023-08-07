using System;
public class MillipedeOfWords
{
    public static void Main()
    {

    }

    public static bool Millipede(string[] arr)
    {
        int n = arr.Length;
        foreach (string word in arr)
        {
            List<string> list = new List<string>(arr);
            list.Remove(word); 
            if (GetNextWord(n, word, list, 1))
            {
                return true;
            }
        }
        return false;
    }

    private static bool GetNextWord(int n, string word, List<string> list, int k)
    {
        if (k == n)
        {
            return true;
        }
        int n1 = list.Count - 1;
        foreach (string word1 in list)
        {
            if (word.Last() == word1.First())
            {
                List<string> list1 = new List<string>(list);
                list1.Remove(word1);
                if (GetNextWord(n, word1, list1, k+1))
                {
                    return true;
                }
            }
        }
        return false;
    }

    /*
     Что это, мать твою

    public static bool Millipede(string[] arr, char e='\0') {
    return !arr.Any() || arr.Any(
    n => (e=='\0' || n[0]==e) && 
      Millipede(arr.Select((p,i) => (p,i))
        .Where(t => t.Item2!=Array.IndexOf(arr,n))
        .Select(t => t.Item1).ToArray(), n.Last())
    );
  }



    1. Создается статический метод Millipede, 
    который принимает массив строк arr и символ e (по умолчанию равен '\0').

2. Возвращается отрицание выражения !arr.Any(). 
    Метод Any() проверяет, содержит ли массив arr хотя бы один элемент.

3. Если массив arr пустой, то возвращается true, иначе выполняется следующее выражение.

4. Метод Any() вызывается на массиве arr, чтобы проверить, 
    содержит ли он хотя бы один элемент, удовлетворяющий условию.

5. Условие предиката 
    (n => (e=='\0'  n[0]==e) && Millipede(arr.Select((p,i) => (p,i))
    .Where(t => t.Item2!=Array.IndexOf(arr,n)).
    Select(t => t.Item1).ToArray(), n.Last())) 
    проверяет, что первый символ элемента массива равен символу e, 
    если e не равен '\0'. 
    Также в этом условии происходит рекурсивный вызов метода Millipede с измененными параметрами.

6. В рекурсивном вызове метода Millipede вызывается метод Select(), 
    который отображает каждый элемент массива arr на новую структуру данных, 
    содержащую сам элемент p и его индекс i.

7. Затем вызывается метод Where(), который фильтрует элементы структуры данных, 
    исключая элементы с индексом равным индексу текущего элемента n в массиве arr.

8. Далее вызывается метод Select(), который отображает отфильтрованные элементы 
    на их первоначальные значения.

9. Получившийся массив передается в рекурсивный вызов метода Millipede, 
    в качестве нового значения для параметра arr.

10. Кроме того, в рекурсивный вызов передается 
    последний символ текущего элемента n массива arr.

11. Рекурсивный вызов продолжается до тех пор, 
    пока не будет выполнено условие из пункта 3 или массив arr станет пустым.

12. В итоге метод Millipede вернет true, 
    если выполняется условие из пункта 3, иначе вернет false.

     
     */
}