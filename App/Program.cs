using System;
using App.Srp.Bad;
using App.Srp.Good;

namespace App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(nameof(SrpBad));
            SrpBad.Example();

            Console.WriteLine(nameof(SrpGood));
            SrpGood.Example();

            Console.WriteLine("Press any key to exit program ..");
            Console.ReadKey();
        }
    }
}
