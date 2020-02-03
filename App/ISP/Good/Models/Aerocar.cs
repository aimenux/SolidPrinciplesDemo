using System;

namespace App.ISP.Good.Models
{
    public class Aerocar : ICar, IAirplane
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