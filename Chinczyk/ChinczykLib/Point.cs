using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    public class Point:IEquatable<Point>
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// porownuje dwa punkty
        /// </summary>
        /// <param name="other"></param>
        /// <returns>zwraca prawde jak punty są równe w przeciwnym wypadku fałsz</returns>
        public bool Equals(Point other)
        {
            if (this.X == other.X && this.Y == other.Y) return true;
            else
                return false;
        }
    }
}
