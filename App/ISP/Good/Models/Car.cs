using System;

namespace App.ISP.Good.Models
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine($"Driving a {nameof(Car)}");
        }
    }
}