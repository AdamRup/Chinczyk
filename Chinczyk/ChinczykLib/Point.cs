using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    /// <summary>
    /// Klasa definiująca punkt na planszy
    /// </summary>
    public class Point:IEquatable<Point>
    {
        /// <summary>
        /// Właściwość przechowująca współrzędną X na planszy
        /// </summary>
        public int X { get; }
        /// <summary>
        /// Właściwość przechowująca współrzędną Y na planszy
        /// </summary>
        public int Y { get; }
        /// <summary>
        /// Konstruktor 2-argumentowy
        /// </summary>
        /// <param name="x">Współrzędna X na planszy</param>
        /// <param name="y">Współrzędna Y na planszy</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Metoda porownująca dwa punkty
        /// </summary>
        /// <param name="other">drugi punkt, z którym obecny obiekt będzie porównywany</param>
        /// <returns>zwraca prawde jak punty są równe w przeciwnym wypadku fałsz</returns>
        public bool Equals(Point other)
        {
            if (this.X == other.X && this.Y == other.Y) return true;
            else
                return false;
        }
    }
}
