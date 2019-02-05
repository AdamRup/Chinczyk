using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    public abstract class Player : IPlayer
    {
        public string Name { get; private set; }
        public int Number { get; private set; }
        protected Pawn[] pawns;
        protected Dice dice;

        public abstract void MovePawn(Pawn pawn);
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
        /// <summary>
        /// Metoda losująca wartość kostki z zakresu 1-6
        /// </summary>
        /// <returns></returns>
        public int RollDice()
        {
            dice.Roll();
            return dice.Value;
        }
    }
}
