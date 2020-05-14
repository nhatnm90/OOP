using System;
using System.Collections.Generic;
using System.Text;

namespace LearningOOP
{
    static class Utils
    {
        internal const int numberOfChar = 69;
        public static void ShowNewLine()
        {
            BreakLine(BuildSplitLine("-"));
        }

        public static void ShowNewLine(string splitChar)
        {
            BreakLine(BuildSplitLine(splitChar));
        }

        private static string BuildSplitLine(string splitChar)
        {
            var breakLine = string.Empty;
            for (int i = 0; i < numberOfChar; i++)
            {
                breakLine += splitChar;
            }
            return breakLine;
        }

        private static void BreakLine(string splitLine)
        {
            Console.WriteLine();
            Console.WriteLine(splitLine);
            Console.WriteLine();
        }
    }
}
