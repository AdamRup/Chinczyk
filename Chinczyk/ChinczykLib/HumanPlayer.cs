using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    /// <summary>
    /// Klasa definiująca gracza (użytkownika)
    /// </summary>
    public class HumanPlayer : Player
    {
        /// <summary>
        /// Konstruktor 2-argumentowy obiektu HumanPlayer
        /// </summary>
        /// <param name="playerName">Nick gracza</param>
        /// <param name="playerNumber">Unikalny numer Gracza</param>
        public HumanPlayer(string playerName, int playerNumber, Point[] pawnPosition, Point[] pawnPath, Point pawnStart, Dice dice)
        {
            pawns = new Pawn[4];
            for (int i = 0; i < pawns.Length; i++)
            {
                pawns[i] = new Pawn(i, pawnPosition[i], pawnPath, pawnStart);
            }
            SetNumber(playerNumber);
            SetName(playerName);
            this.dice = dice;
        }


        /// <summary>
        /// Metoda przesuwająca pionek gracza
        /// </summary>
        /// <param name="pawn">pionek, który ma zostać przesunięty</param>
        public override void MovePawn(Pawn pawn)
        {
            pawn.Move(dice.Value);
        }

        /// <summary>
        /// Metoda zwracająca pionek, który ma zostać przesunięty
        /// </summary>
        /// <param name="pawnNumber">wartość typu int z numerem pionka</param>
        /// <returns>Pionek, który wybrał gracz do przesunięcia na planszy</returns>
        public Pawn SelectPawn(int pawnNumber)
        {
            return pawns[pawnNumber-1];
        }
    }
}
