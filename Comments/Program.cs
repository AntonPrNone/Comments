using System;

namespace Comments
{
    internal class Program
    {
        internal const int AdditionaCharacters = 13;
        internal const int MaxLen = 125;

        static void Main(string[] args)
        {
            while (true)
            { 
                Com(Console.ReadLine());
                Console.WriteLine();
            }
            
        }

        static void Com(string text)
        {
            int Len = text.Length;
            int numberLines = MaxLen - Len - AdditionaCharacters;
            for (int i = 0; i < numberLines / 2; i++)
            { 
                Console.Write('-');
            }
        }
    }
}
