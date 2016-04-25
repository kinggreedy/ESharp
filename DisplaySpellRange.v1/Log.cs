﻿using System;

namespace DisplaySpellRange
{
    internal class Log
    {
        public static void Info(string text, params object[] arguments)
        {
            PrintColor(text, ConsoleColor.White, arguments);
        }

        public static void Success(string text, params object[] arguments)
        {
            PrintColor(text, ConsoleColor.Green, arguments);
        }

        // ReSharper disable once UnusedMember.Local
        public static void Error(string text, params object[] arguments)
        {
            PrintColor(text, ConsoleColor.Red, arguments);
        }

        public static void PrintColor(string text, ConsoleColor color, params object[] arguments)
        {
            var clr = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text, arguments);
            Console.ForegroundColor = clr;
        }
    }
}