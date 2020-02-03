using System;
using App.Extensions;
using App.ISP.Good.Models;

namespace App.ISP.Good
{
    public static class IspGoodExample
    {
        public static void Run()
        {
            ConsoleColor.Green.WriteLine(nameof(IspGoodExample));

            new Car().Drive();

            new Aerocar().Drive();
            new Aerocar().Fly();

            new Airplane().Fly();
        }
    }
}
