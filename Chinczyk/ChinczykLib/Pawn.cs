using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    public class Pawn
    {

        public string ImgPath { get; }
        public int Position { get; private set; }
        public string PawnColor { get; }
        public int NumberPaw { get; }


        /// <summary>
        /// Konstruktor obiektu Pawn cztero argumentowy 
        /// </summary>
        /// <param name="_NumberPawn"> numer pionka (unikalnu)</param>
        /// <param name="_Position"> pozycja pionka na mapie</param>
        /// <param name="_PawnColor">kolor ponka </param>
        /// <param name="_ImgePath"> scieżka do grafiki pionka</param>
        public Pawn(int _NumberPawn , int _Position , string  _PawnColor , string _ImgePath)
        {
            NumberPaw = _NumberPawn;
            Position = _Position;
            PawnColor = _PawnColor;
            ImgPath = _ImgePath;

        }
        /// <summary>
        /// Konstruktor obiektu Pawn trzy argumentowy 
        /// </summary>
        /// <param name="_NumberPawn"> numer pionka (unikalnu)</param>
        /// <param name="_Position"> pozycja pionka na mapie</param>
        /// <param name="_PawnColor">kolor ponka </param>
        public Pawn(int _NumberPawn, int _Position, string _PawnColor):this(_NumberPawn  , _Position , _PawnColor , "")
        {
        }
        /// <summary>
        /// Konstruktor obiektu Pawn dwu argumentowy 
        /// </summary>
        /// <param name="_NumberPawn"> numer pionka (unikalnu)</param>
        /// <param name="_Position"> pozycja pionka na mapie</param>
        public Pawn(int _NumberPawn, int _Position) : this(_NumberPawn, _Position, "", "")
        {
        }

        /// <summary>
        /// Przesuwanie pionka o daną liczbe pol na mapie
        /// </summary>
        /// <param name="NewPosition">O ile pol ma się przesunoc pionek</param>
        public void Move(int NewPosition  , GameBoard gameBoard)
        {


            this.Position += NewPosition;
            
        }











    }
}
