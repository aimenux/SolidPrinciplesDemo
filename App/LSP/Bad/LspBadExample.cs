using System;
using App.Extensions;
using App.LSP.Bad.Models;

namespace App.LSP.Bad
{
    public static class LspBadExample
    {
        private static readonly Type BaseType = typeof(Apple);

        // Orange SubType cannot substitute an Apple BaseType
        // because this alter the correctness of the program
        public static void Run()
        {
            ConsoleColor.Red.WriteLine(nameof(LspBadExample));

            // Call with BaseType which print green as color for an apple
            PrintColor(new Apple());

            // Call with SubType which print orange as color for an apple
            PrintColor(new Orange());
        }

        private static void PrintColor(Apple apple)
        {
            var typeName = BaseType.Name;
            var typeColor = apple.GetColor();
            Console.WriteLine($"Color for {typeName} is {typeColor}");
        }
    }
}
