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
            dice.Roll();
            try
            {
                MovePawn(SelectPawn());
            }
            catch (Exception e)
            {
                throw e;
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
        /// losowy wybór pionka przez gracza komputerowego
        /// </summary>
        /// <returns></returns>
        public Pawn SelectPawn()
        {
            Random random = new Random();
            return pawns[random.Next(0, 4)];
        }
    }
}
