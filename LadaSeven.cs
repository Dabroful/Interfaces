using System;

namespace Interfaces
{
    public class LadaSeven : ICar, IDisposable
    {
        public int Move(int distance)
        {
            //подразумевается что машина едет со скоростью 40 км/ч. Дистанцию делим на 40.
            return distance / 40;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}