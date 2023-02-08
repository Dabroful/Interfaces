using System.Collections.Generic;

namespace Interfaces
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new LadaSeven());
            cars.Add(new BMWseven());

            foreach (var car in cars)
            {
                car.Move(200);
            }

            Cyborg cyborg = new Cyborg();
            ((ICar)cyborg).Move(100);
            ((IPerson)cyborg).Move(100);
            
            //в результате действий выше киборг приодолел расстояние в 100км будучи машиной за 4 часа и будучи человеком за 20 часов.
        }
    }
}