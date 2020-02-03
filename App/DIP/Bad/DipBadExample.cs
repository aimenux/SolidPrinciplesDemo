using System;
using App.DIP.Bad.Services;
using App.Extensions;

namespace App.DIP.Bad
{
    public static class DipBadExample
    {
        public static void Run()
        {
            ConsoleColor.Red.WriteLine(nameof(DipBadExample));

            var sender = new SenderService();
            sender.Send();
        }
    }
}
