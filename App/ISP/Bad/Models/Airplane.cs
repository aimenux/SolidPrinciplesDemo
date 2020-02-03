using System;

namespace App.ISP.Bad.Models
{
    public class Airplane : IVehicle
    {
        public void Drive()
        {
            throw new NotImplementedException($"{nameof(Drive)} is not implemented for {nameof(Airplane)}");
        }

        public void Fly()
        {
            Console.WriteLine($"Flying an {nameof(Airplane)}");
        }
    }
}