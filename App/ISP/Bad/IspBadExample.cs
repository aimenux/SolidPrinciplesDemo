using System;
using App.Extensions;
using App.ISP.Bad.Models;

namespace App.ISP.Bad
{
    public static class IspBadExample
    {
        public static void Run()
        {
            ConsoleColor.Red.WriteLine(nameof(IspBadExample));

            new Car().Drive();
            SafeExecute(() => new Car().Fly());

            new Aerocar().Drive();
            new Aerocar().Fly();

            SafeExecute(() => new Airplane().Drive());
            new Airplane().Fly();
        }

        private static void SafeExecute(Action action)
        {
            try
            {
                action?.Invoke();
            }
            catch(Exception ex)
            {
                ConsoleColor.Gray.WriteLine(ex.Message);
            }
        }
    }
}
