namespace Interfaces
{
    public class Kalibr : IRocket
    {
        public int Move(int distance)
        {
            return distance / 11000;
        }
    }
}