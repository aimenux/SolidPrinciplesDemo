using System;
using App.Extensions;
using App.LSP.Good.Models;

namespace App.LSP.Good
{
    public static class LspGoodExample
    {
        private static readonly Type BaseType = typeof(Fruit);

        // We can replace Fruit BaseType with any SubType Apple or
        // Orange without altering the correctness of the program
        public static void Run()
        {
            ConsoleColor.Green.WriteLine(nameof(LspGoodExample));

            // Call with SubType Apple which print green as color for an apple fruit
            PrintColor(new Apple());

            // Call with SubType Orange which print orange as color for an orange fruit
            PrintColor(new Orange());
        }

        private static void PrintColor(Fruit fruit)
        {
            var typeName = BaseType.Name;
            var typeColor = fruit.GetColor();
            Console.WriteLine($"Color for {typeName} is {typeColor}");
        }
    }
}
