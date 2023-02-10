using System;
using System.Collections.Generic;

namespace Interfaces
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var rockets = new List<IRocket>();
            rockets.Add(new Circone());
            rockets.Add(new Kalibr());

            foreach (var rocket in rockets)
            {
                Console.WriteLine(rocket.Move(23000));
            }

            Shatl shatl = new Shatl();
            Console.WriteLine(((IRocket)shatl).Move(23000));
            Console.WriteLine(((ISpaceShip)shatl).Move(23000));
        }
    }
}