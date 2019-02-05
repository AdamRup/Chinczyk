using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    public class Pawn
    {

        private int field;
        private Point[] path;
        private Point startPosition;

        public string ImgPath { get; }
        public Point Position { get; private set; }
        public string PawnColor { get; }
        public int NumberPaw { get; }


        /// <summary>
        /// Konstruktor obiektu Pawn cztero argumentowy 
        /// </summary>
        /// <param name="_NumberPawn">Numer pionka (unikalny)</param>
        /// <param name="_Position">Pozycja startowan pionka na mapie</param>
        /// <param name="_PawnColor">Kolor ponka </param>
        /// <param name="_ImgePath"> Scieżka do grafiki pionka</param>
        /// <param name="_Path">Scieżka po której pionek przemieszcza się po mapie</param>
        /// <param name="_StartPosition">Poczotkowy punk od którego pionek rozpoczyna pordróż po mapie</param>
        public Pawn(int _NumberPawn, Point _Position,  Point[] _Path, Point _StartPosition, string _PawnColor, string _ImgePath)
        { 
            NumberPaw = _NumberPawn;
            Position = _Position;
            PawnColor = _PawnColor;
            ImgPath = _ImgePath;
            path = _Path;
            startPosition = _StartPosition;

        }
        /// <summary>
        /// Konstruktor obiektu Pawn trzy argumentowy 
        /// </summary>
        /// <param name="_NumberPawn"> Numer pionka (unikalny)</param>
        /// <param name="_Position">Pozycja startowan pionka na mapie</param>
        /// <param name="_PawnColor">Kolor ponka </param>
        /// <param name="_Path">Scieżka po której pionek przemieszcza się po mapie</param>
        /// <param name="_StartPosition">Poczotkowy punk od którego pionek rozpoczyna pordróż po mapie</param>
        public Pawn(int _NumberPawn, Point _Position, string _PawnColor , Point[] _Path, Point _StartPosition) : this(_NumberPawn, _Position, _Path , _StartPosition, _PawnColor, "")
        {
        }
        /// <summary>
        /// onstruktor obiektu Pawn dwu argumentowy 
        /// </summary>
        /// <param name="_NumberPawn">Numer pionka (unikalny)</param>
        /// <param name="_Position">Pozycja startowan pionka na mapie</param>
        /// <param name="_Path">Scieżka po której pionek przemieszcza się po mapie</param>
        /// <param name="_StartPosition">Poczotkowy punk od którego pionek rozpoczyna pordróż po mapie</param>
        public Pawn(int _NumberPawn, Point _Position , Point[] _Path , Point _StartPosition) : this(_NumberPawn, _Position,_Path ,_StartPosition, "" ,"")
        {
            

        }

        /// <summary>
        /// Przesuwanie pionka o daną liczbe pol na mapie
        /// </summary>
        /// <param name="NewPosition">O ile pol ma się przesunoc pionek</param>
        /// <param name="path">Tabela z polami po których ma sie poruszac pionek </param>
        public void Move(int NewPosition )
        {
            if(!(field + NewPosition >=44))
            {
                Position = path[field + NewPosition];
                field = field + NewPosition;
            }
            else
            {
                throw new Exception("Nie możesz poruszyc tym pionkime");
            }

            
        }
        /// <summary>
        /// Opuszczenie bazy przez pionek
        /// </summary>
        /// <param name="StartPoint"> Pozycja od której pionek rozpoczyna przejście po mapie </param>
        public void LeaveTheBase()
        {
            Position = startPosition;
            field = 0;
        }

       













    }
}
