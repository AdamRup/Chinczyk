using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChinczykLib;

namespace ProgramTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard g1 = new GameBoard(50 ,50);
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i<g1.PathPoint.Length; i++)
            {
                Console.SetCursorPosition(g1.PathPoint[i].X, g1.PathPoint[i].Y);
                Console.Write("+");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(g1.StartPointPlayer1.X, g1.StartPointPlayer1.Y);
            Console.Write("+");
            for (int i= 0; i<4; i++)
            {
                Console.SetCursorPosition(g1.BasePointPlayer1[i].X, g1.BasePointPlayer1[i].Y);
                Console.Write("+");
                Console.SetCursorPosition(g1.FinishPointPlayer1[i].X, g1.FinishPointPlayer1[i].Y);
                Console.Write("+");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(g1.StartPointPlayer2.X, g1.StartPointPlayer2.Y);
            Console.Write("+");
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(g1.BasePointPlayer2[i].X, g1.BasePointPlayer2[i].Y);
                Console.Write("+");
                Console.SetCursorPosition(g1.FinishPointPlayer2[i].X, g1.FinishPointPlayer2[i].Y);
                Console.Write("+");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(g1.StartPointPlayer3.X, g1.StartPointPlayer3.Y);
            Console.Write("+");
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(g1.BasePointPlayer3[i].X, g1.BasePointPlayer3[i].Y);
                Console.Write("+");
                Console.SetCursorPosition(g1.FinishPointPlayer3[i].X, g1.FinishPointPlayer3[i].Y);
                Console.Write("+");
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(g1.StartPointPlayer4.X, g1.StartPointPlayer4.Y);
            Console.Write("+");
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(g1.BasePointPlayer4[i].X, g1.BasePointPlayer4[i].Y);
                Console.Write("+");
                Console.SetCursorPosition(g1.FinishPointPlayer4[i].X, g1.FinishPointPlayer4[i].Y);
                Console.Write("+");
            }
            
            Console.SetCursorPosition(50, 60);
        }
    }
}
