using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    public class HumanPlayer : Player
    {
        /// <summary>
        /// Konstruktor 2-argumentowy obiektu HumanPlayer
        /// </summary>
        /// <param name="playerName">Nick gracza</param>
        /// <param name="playerNumber">Unikalny numer Gracza</param>
        public HumanPlayer(string playerName, int playerNumber)
        {
            pawns = new Pawn[4];
            for (int i=0; i<pawns.Length; i++)
            {
               // pawns[i] = new Pawn(10*playerNumber+i, 10 * playerNumber + i);  // zmienić pozycję pionka dla właściwej pozycji na planszy
            }
            SetNumber(playerNumber);
            SetName(playerName);
        }
        // wybór pionka
        public override int SelectPawn()
        {
            throw new NotImplementedException();
        }
    }
}
