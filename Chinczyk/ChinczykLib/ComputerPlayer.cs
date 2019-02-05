using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    public class ComputerPlayer : Player
    {
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

        public void Play()
        {
            dice.Roll();
            MovePawn(SelectPawn());
        }

        public override void MovePawn(Pawn pawn)
        {
            pawn.Move(dice.Value);
        }

        // wersja Alpha - do zmiany ze względu na wybrany poziom trudności
        public Pawn SelectPawn()
        {
            /*
            Pawn pawn;
            for (int i = 0; i < pawns.Length; i++)
            {
                if (pawns[i].NumberPaw == pawnNumber)
                {
                    pawn = pawns[i];
                }
                else
                {
                    pawn = pawns[0];
                }
            }
            return pawn;
            */
            throw new NotImplementedException();
        }
    }
}
