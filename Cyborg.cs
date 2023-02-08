namespace Interfaces
{
    public class Cyborg : ICar, IPerson
    {
        public int Move(int distance)
        {
            //дистанцию мы здесь делим на 100, потому что скорость передвижения 100км в час.
            return distance / 100;
        }

        int IPerson.Move(int distance)
        {
            //здесь то же амое, только скорость 5 км в час.
            return distance / 5;
        }
    }
    
}