using System;

namespace App.ISP.Bad.Models
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine($"Driving a {nameof(Car)}");
        }

        public void Fly()
        {
            throw new NotImplementedException($"{nameof(Fly)} is not implemented for {nameof(Car)}");
        }
    }
}
