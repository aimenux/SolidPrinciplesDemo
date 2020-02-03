using System;

namespace App.ISP.Bad.Models
{
    public class Aerocar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine($"Driving a {nameof(Aerocar)}");
        }

        public void Fly()
        {
            Console.WriteLine($"Flying an {nameof(Aerocar)}");
        }
    }
}