using System;
using App.Extensions;
using App.Ocp.Bad;
using App.Ocp.Good;
using App.Srp.Bad;
using App.Srp.Good;

namespace App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            SrpBadExample.Run();
            SrpGoodExample.Run();

            OcpBadExample.Run();
            OcpGoodExample.Run();

            ConsoleColor.Yellow.WriteLine("Press any key to exit program ..");
            Console.ReadKey();
        }
    }
}
