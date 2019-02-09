using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    /// <summary>
    /// Klasa definiująca pionka do gry(Pawn)
    /// </summary>
    public class Pawn : IPawn
    {

        private int field;
        private Point[] path;
        private Point startPosition;
        /// <summary>
        /// Właściwość informująca o tym, czy pionek opuścił pole początkowe
        /// </summary>
        public bool IsLeaveTheBase { get; private set; }
        /// <summary>
        /// Właściwość informująca o aktywności pionka
        /// </summary>
        public bool IsActive {get ; set;}
        /// <summary>
        /// Właściwość przechowująca ścieżkę do zdjęcia pionka
        /// </summary>
        public string ImgPath { get; }
        /// <summary>
        /// Właściwość przechowująca pozycję pionka
        /// </summary>
        public Point Position { get; private set; }
        /// <summary>
        /// Właściwość przechowująca kolor pionka
        /// </summary>
        public string PawnColor { get; }
        /// <summary>
        /// Właściwość przechowująca numer pionka
        /// </summary>
        public int NumberPaw { get; }


        /// <summary>
        /// Konstruktor obiektu Pawn 4-argumentowy 
        /// </summary>
        /// <param name="_NumberPawn">Numer pionka (unikalny)</param>
        /// <param name="_Position">Pozycja startowa pionka na mapie</param>
        /// <param name="_PawnColor">Kolor ponka </param>
        /// <param name="_ImgePath"> Scieżka do grafiki pionka</param>
        /// <param name="_Path">Scieżka po której pionek przemieszcza się po mapie</param>
        /// <param name="_StartPosition">Początkowy punkt od którego pionek rozpoczyna pordróż po mapie</param>
        public Pawn(int _NumberPawn, Point _Position,  Point[] _Path, Point _StartPosition, string _PawnColor, string _ImgePath)
        { 
            NumberPaw = _NumberPawn;
            Position = _Position;
            PawnColor = _PawnColor;
            ImgPath = _ImgePath;
            path = _Path;
            startPosition = _StartPosition;
            IsActive = true;
            IsLeaveTheBase = false;
            field = 0;
        }
        /// <summary>
        /// Konstruktor obiektu Pawn 3-argumentowy 
        /// </summary>
        /// <param name="_NumberPawn"> Numer pionka (unikalny)</param>
        /// <param name="_Position">Pozycja startowa pionka na mapie</param>
        /// <param name="_PawnColor">Kolor ponka </param>
        /// <param name="_Path">Scieżka po której pionek przemieszcza się po mapie</param>
        /// <param name="_StartPosition">Początkowy punkt od którego pionek rozpoczyna pordróż po mapie</param>
        public Pawn(int _NumberPawn, Point _Position, string _PawnColor , Point[] _Path, Point _StartPosition) : this(_NumberPawn, _Position, _Path , _StartPosition, _PawnColor, "")
        {
        }
        /// <summary>
        /// Konstruktor obiektu Pawn 2-argumentowy 
        /// </summary>
        /// <param name="_NumberPawn">Numer pionka (unikalny)</param>
        /// <param name="_Position">Pozycja startowa pionka na mapie</param>
        /// <param name="_Path">Scieżka po której pionek przemieszcza się po mapie</param>
        /// <param name="_StartPosition">Początkowy punkt od którego pionek rozpoczyna pordróż po mapie</param>
        public Pawn(int _NumberPawn, Point _Position , Point[] _Path , Point _StartPosition) : this(_NumberPawn, _Position,_Path ,_StartPosition, "" ,"")
        {
            

        }

        /// <summary>
        /// Przesuwanie pionka o daną liczbe pol na mapie
        /// </summary>
        /// <param name="NewPosition">O ile pol ma się przesunoc pionek</param>
        public void Move(int NewPosition)
        {
            if (IsLeaveTheBase == false)
            {
                LeaveTheBase();
            }
            else
            {
                Position = ReturnNewPosition(NewPosition);
                field = field + NewPosition;
            }
           
            
        }
        /// <summary>
        /// funkcja która sprawdz czy pionek może sie poruszyć o zadaną ilośc pól jeżeli tak zwraca nową pozycje  a w przecinym wypadku zwraca pozycie aktulaną
        /// </summary>
        /// <param name="NewPosition"></param>
        /// <returns>zwrócenie nowej pozycji pionka</returns>
        public Point ReturnNewPosition(int NewPosition)
        {
            if ((!(field + NewPosition >= 44))&&IsLeaveTheBase==true)
            {
                return path[field + NewPosition];
                

            }
            else
            {
                return path[field];
            }
        }


        /// <summary>
        /// Opuszczenie bazy przez pionka
        /// </summary>
        public void LeaveTheBase()
        {
            if (IsActive)
            {
                IsLeaveTheBase = true;
                Position = startPosition;
                field = 0;
            }
            
        }

       













    }
}
