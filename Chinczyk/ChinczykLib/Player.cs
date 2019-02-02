using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    public abstract class Player
    {
        public string Name { get; private set; }
        public int Number { get; private set; }
        protected Pawn[] pawns;

        public abstract int SelectPawn();
        /// <summary>
        /// Metoda ustawiająca unikalny numer gracza
        /// </summary>
        /// <param name="playerNumber">unikalny numer gracza</param>
        public void SetNumber(int playerNumber)
        {
            Number = playerNumber;
        }
        /// <summary>
        /// Metoda ustawiająca imię/nick gracza
        /// </summary>
        /// <param name="playerName"></param>
        public void SetName(string playerName)
        {
            Name = playerName;
        }
    }
}
