using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JumpingLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var strLine = "Hello,World!!! C# Conio Example!!!";
            var nLen = strLine.Length;
            Console.Clear();
            Console.CursorVisible = false;
            for (int i = 0; i < nLen; i++)
            {
                for (int j = 70; j > 10 + i; j--)
                {
                    Console.SetCursorPosition(10 + j, 10);
                    Console.Write(strLine[i] + " ");
                    Thread.Sleep(5);
                }
            }
            Console.SetCursorPosition(10, 10);
            Console.Write(strLine);
            Console.SetCursorPosition(10, 11);
            Console.Write("Press any key");
            Console.ReadKey();
        }
    }
}
