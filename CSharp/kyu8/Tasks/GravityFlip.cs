namespace Tasks
{
    internal class GravityFlip
    {
        public static int[] Flip(char dir, int[] arr)
        {
            int[] answer = arr;
            Array.Sort(answer);
            // можно было написать arr.OrderBy и OrderDescendingBy
            if (dir == 'L')
                Array.Reverse(answer);
            return answer;
        }
    }
}
