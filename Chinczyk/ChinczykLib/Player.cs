using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    /// <summary>
    /// Klasa abstrakcyjna definiująca gracza
    /// </summary>
    public abstract class Player : IPlayer
    {
        /// <summary>
        /// Właściwość przechowująca imię/nick gracza
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Właściwość przechowująca unikalny numer gracza
        /// </summary>
        public int Number { get; private set; }
        /// <summary>
        /// Tablica przechowująca pionki gracza
        /// </summary>
        public  Pawn[] pawns;
        /// <summary>
        /// Zmienna przechowująca obiekt kostki do gry
        /// </summary>
        protected Dice dice;
        /// <summary>
        /// Metoda abstrakcyjna przesuwająca wskazany pionek gracza
        /// </summary>
        /// <param name="pawn">pionek, który ma zostać przesunięty na planszy</param>
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
        /// <param name="playerName">nick gracza</param>
        public void SetName(string playerName)
        {
            Name = playerName;
        }    
    }
}
