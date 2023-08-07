namespace Tasks
{
    internal class Quadrants
    {
        public static int Quadrant(int x, int y) =>
            x > 0 ? y > 0 ? 1 : 4 : y > 0 ? 2 : 3;
        
    }
}
