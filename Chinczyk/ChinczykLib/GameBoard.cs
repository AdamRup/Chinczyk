using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    public class GameBoard
    {

        public Point[] PathPoint { get; }

        public Point[] PathPlayer1
        {
            get
            {
                Point[] tmp = new Point[44];
                for(int i = 30; i<70; i++)
                {
                    tmp[i - 30] = PathPoint[i % 40];
                }
                tmp[40] = FinishPointPlayer1[0];
                tmp[41] = FinishPointPlayer1[1];
                tmp[42] = FinishPointPlayer1[2];
                tmp[43] = FinishPointPlayer1[3];
                return tmp;
            }


        }

        public Point[] PathPlayer2
        {
            get
            {
                Point[] tmp = new Point[44];
                for (int i = 0; i < 40; i++)
                {
                    tmp[i] = PathPoint[i % 40];
                }
                tmp[40] = FinishPointPlayer2[0];
                tmp[41] = FinishPointPlayer2[1];
                tmp[42] = FinishPointPlayer2[2];
                tmp[43] = FinishPointPlayer2[3];
                return tmp;
            }


        }

        public Point[] PathPlayer3
        {
            get
            {
                Point[] tmp = new Point[44];
                for (int i = 20; i < 60; i++)
                {
                    tmp[i-20] = PathPoint[i % 40];
                }
                tmp[40] = FinishPointPlayer3[0];
                tmp[41] = FinishPointPlayer3[1];
                tmp[42] = FinishPointPlayer3[2];
                tmp[43] = FinishPointPlayer3[3];
                return tmp;
            }


        }

        public Point[] PathPlayer4
        {
            get
            {
                Point[] tmp = new Point[44];
                for (int i = 10; i < 50; i++)
                {
                    tmp[i-10] = PathPoint[i % 40];
                }
                tmp[40] = FinishPointPlayer4[0];
                tmp[41] = FinishPointPlayer4[1];
                tmp[42] = FinishPointPlayer4[2];
                tmp[43] = FinishPointPlayer4[3];
                return tmp;
            }


        }



        public Point StartPointPlayer1 { get { return PathPoint[30]; } }
        public Point StartPointPlayer2 { get { return PathPoint[0]; } }
        public Point StartPointPlayer3 { get { return PathPoint[20]; } }
        public Point StartPointPlayer4 { get { return PathPoint[10]; } }

        public Point[] BasePointPlayer1 { get; }
        public Point[] BasePointPlayer2 { get; }
        public Point[] BasePointPlayer3 { get; }
        public Point[] BasePointPlayer4 { get; }

        public Point[] FinishPointPlayer1 { get; }
        public Point[] FinishPointPlayer2 { get; }
        public Point[] FinishPointPlayer3 { get; }
        public Point[] FinishPointPlayer4 { get; }

        /// <summary>
        /// Konstruktor Clasy GameBoard
        /// </summary>
        /// <param name="width">Wysokość mapy</param>
        /// <param name="height">Szerokość mapy</param>
        public GameBoard(int width, int height)
        {
            width /= 11;
            height /= 11;

            PathPoint = new Point[40];

            BasePointPlayer1 = new Point[4];
            BasePointPlayer2 = new Point[4];
            BasePointPlayer3 = new Point[4];
            BasePointPlayer4 = new Point[4];

            FinishPointPlayer1 = new Point[4];
            FinishPointPlayer2 = new Point[4];
            FinishPointPlayer3 = new Point[4];
            FinishPointPlayer4 = new Point[4];


            ///scieżka po której musi przejść gracz 
         PathPoint[0] = new Point(width* 7, height);
        PathPoint[1] = new Point(width* 7, height* 2);
        PathPoint[2] = new Point(width* 7, height* 3);
        PathPoint[3] = new Point(width* 7, height* 4);
        PathPoint[4] = new Point(width* 7, height* 5);
        PathPoint[5] = new Point(width* 8, height* 5);
        PathPoint[6] = new Point(width* 9, height* 5);
        PathPoint[7] = new Point(width* 10, height* 5);
        PathPoint[8] = new Point(width* 11, height* 5);
        PathPoint[9] = new Point(width* 11, height* 6);
        PathPoint[10] = new Point(width* 11, height* 7);
        PathPoint[11] = new Point(width* 10, height* 7);
        PathPoint[12] = new Point(width* 9, height* 7);
        PathPoint[13] = new Point(width* 8, height* 7);
        PathPoint[14] = new Point(width* 7, height* 7);
        PathPoint[15] = new Point(width* 7, height* 8);
        PathPoint[16] = new Point(width* 7, height* 9);
        PathPoint[17] = new Point(width* 7, height* 10);
        PathPoint[18] = new Point(width* 7, height* 11);
        PathPoint[19] = new Point(width* 6, height* 11);
        PathPoint[20] = new Point(width* 5, height* 11);
        PathPoint[21] = new Point(width* 5, height* 10);
        PathPoint[22] = new Point(width* 5, height* 9);
        PathPoint[23] = new Point(width* 5, height* 8);
        PathPoint[24] = new Point(width* 5, height* 7);
        PathPoint[25] = new Point(width* 4, height* 7);
        PathPoint[26] = new Point(width* 3, height* 7);
        PathPoint[27] = new Point(width* 2, height* 7);
        PathPoint[28] = new Point(width, height* 7);
        PathPoint[29] = new Point(width, height* 6);
        PathPoint[30] = new Point(width, height* 5);
        PathPoint[31] = new Point(width* 2, height* 5);
        PathPoint[32] = new Point(width* 3, height* 5);
        PathPoint[33] = new Point(width* 4, height* 5);
        PathPoint[34] = new Point(width* 5, height* 5);
        PathPoint[35] = new Point(width* 5, height* 4);
        PathPoint[36] = new Point(width* 5, height* 3);
        PathPoint[37] = new Point(width* 5, height* 2);
        PathPoint[38] = new Point(width* 5, height);
        PathPoint[39] = new Point(width* 6, height);


        ///palyer 1 //////////////////////////////////////////////////////
        // BasePlayer1
        BasePointPlayer1[0] = new Point(width, height);
        BasePointPlayer1[1] = new Point(width* 2, height);
        BasePointPlayer1[2] = new Point(width, height*2);
        BasePointPlayer1[3] = new Point(width*2, height* 2);
       
            //FinishPointPlayer1
            FinishPointPlayer1[0] = new Point(width*2, height*6);
        FinishPointPlayer1[1] = new Point(width*3, height*6);
        FinishPointPlayer1[2] = new Point(width*4, height*6);
        FinishPointPlayer1[3] = new Point(width*5, height*6);

        ///palyer 2 //////////////////////////////////////////////////////
      
            //FinishPointPlayer2
            FinishPointPlayer2[0] = new Point(width*6 , height*2 );
        FinishPointPlayer2[1] = new Point(width*6 , height*3 );
        FinishPointPlayer2[2] = new Point(width*6 , height*4 );
        FinishPointPlayer2[3] = new Point(width*6, height*5  );
        // BasePlayer2
        BasePointPlayer2[0] = new Point(width*10, height);
        BasePointPlayer2[1] = new Point(width*11, height);
        BasePointPlayer2[2] = new Point(width*10, height*2);
        BasePointPlayer2[3] = new Point(width*11, height*2);

        ///palyer 3 //////////////////////////////////////////////////////
        
        //FinishPointPlayer3
        FinishPointPlayer3[0] = new Point(width*6, height*10);
        FinishPointPlayer3[1] = new Point(width*6, height*9);
        FinishPointPlayer3[2] = new Point(width*6, height*8);
        FinishPointPlayer3[3] = new Point(width*6, height*7);
        // BasePlayer3
        BasePointPlayer3[0] = new Point(width, height*10);
        BasePointPlayer3[1] = new Point(width*2, height*10);
        BasePointPlayer3[2] = new Point(width, height*11);
        BasePointPlayer3[3] = new Point(width*2, height*11);

        ///palyer 4 //////////////////////////////////////////////////////
       
        //FinishPointPlayer4
        FinishPointPlayer4[0] = new Point(width*10, height*6);
        FinishPointPlayer4[1] = new Point(width*9, height*6);
        FinishPointPlayer4[2] = new Point(width*8, height*6);
        FinishPointPlayer4[3] = new Point(width*7, height*6);
        // BasePlayer4
        BasePointPlayer4[0] = new Point(width*10, height*10);
        BasePointPlayer4[1] = new Point(width*11, height*10);
        BasePointPlayer4[2] = new Point(width*10, height*11);
        BasePointPlayer4[3] = new Point(width*11, height*11);







        }

     

      
        


        





    }
}
