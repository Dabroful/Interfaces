namespace Interfaces
{
    public class BMWseven : ICar
    {
        public int Move(int distance)
        {
            //скорость машины в данном случае 100 км в час
            return distance / 100;
        }
    }
}