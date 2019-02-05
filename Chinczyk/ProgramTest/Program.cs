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
            
          


            Pawn p1 = new Pawn(1, g1.BasePointPlayer1[0] , g1.PathPlayer1,g1.StartPointPlayer1);
            Pawn p2 = new Pawn(1, g1.BasePointPlayer2[0], g1.PathPlayer2,g1.StartPointPlayer2);

            p1.LeaveTheBase();
            p2.LeaveTheBase();
         
            p1.Move(0);
            p2.Move(43);

            


            Console.SetCursorPosition(p1.Position.X , p1.Position.Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("X");
            Console.SetCursorPosition(p2.Position.X, p2.Position.Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("0");
        



            Console.SetCursorPosition(50, 60);
            Console.WriteLine(p1.Position.X == p2.Position.X);
            

        }
    }
}
