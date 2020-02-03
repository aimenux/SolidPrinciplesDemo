using System;

namespace App.ISP.Good.Models
{
    public class Airplane : IAirplane
    {
        public void Fly()
        {
            Console.WriteLine($"Flying an {nameof(Airplane)}");
        }
    }
}