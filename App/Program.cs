using System;
using App.Extensions;
using App.LSP.Bad;
using App.LSP.Good;
using App.OCP.Bad;
using App.OCP.Good;
using App.SRP.Bad;
using App.SRP.Good;

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

            LspBadExample.Run();
            LspGoodExample.Run();

            ConsoleColor.Yellow.WriteLine("Press any key to exit program ..");
            Console.ReadKey();
        }
    }
}
