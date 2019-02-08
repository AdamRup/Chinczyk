using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    public class ComputerPlayer : Player
    {
        /// <summary>
        /// konstruktor 5-argumentowy tworzący obiekt klasy ComputerPlayer
        /// </summary>
        /// <param name="playerNumber">numer gracza</param>
        /// <param name="pawnPosition">tablica z pozycjami pionków</param>
        /// <param name="pawnPath">ścieżka pionka</param>
        /// <param name="pawnStart">pozycja startowa pionka</param>
        /// <param name="dice"></param>
        public ComputerPlayer (int playerNumber, Point[] pawnPosition, Point[] pawnPath, Point pawnStart, Dice dice)
        {
            pawns = new Pawn[4];
            for (int i = 0; i < pawns.Length; i++)
            {
                pawns[i] = new Pawn(i, pawnPosition[i], pawnPath, pawnStart);
            }
            SetNumber(playerNumber);
            SetName("Player " + playerNumber);
            this.dice = dice;
        }

        /// <summary>
        /// Metoda, która wywołuje cząstkowe metody podczas rundy gracza komputerowego
        /// </summary>
        public void Play()
        {
            if(!(SelectPawn() is null))
            {
                MovePawn(SelectPawn());
            }
            
            
        }
        /// <summary>
        /// Metoda przesuwająca pionek gracza komputerowego
        /// </summary>
        /// <param name="pawn">pionek, który ma zostać przesunięty</param>
        public override void MovePawn(Pawn pawn)
        {
           pawn.Move(dice.Value);
        }

        /// <summary>
        /// losowy  pionka przez gracza komputerowego
        /// </summary>
        /// <returns></returns>
        public Pawn SelectPawn()
        {
            if (pawns[0].IsActive)
                return pawns[0];
            if (pawns[1].IsActive)
                return pawns[1];
            if (pawns[2].IsActive)
                return pawns[2];
            if (pawns[3].IsActive)
                return pawns[3];

            return null;
        }
    }
}
