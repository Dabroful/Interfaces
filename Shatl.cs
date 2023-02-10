namespace Interfaces
{
    public class Shatl : ISpaceShip
    {
        public int Move(int distance)
        {
            return distance / 3500;
        }
    }
}