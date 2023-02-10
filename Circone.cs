namespace Interfaces
{
    public class Circone : IRocket
    {
        public int Move(int distance)
        {
            return distance / 7000;
        }
    }
}