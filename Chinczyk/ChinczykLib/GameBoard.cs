﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    public class GameBoard
    {

        public Point[] PathPoint { get; }

        public Point StartPointPlayer1 { get; }
        public Point StartPointPlayer2 { get; }
        public Point StartPointPlayer3 { get; }
        public Point StartPointPlayer4 { get; }

        public Point[] BasePointPlayer1 { get; }
        public Point[] BasePointPlayer2 { get; }
        public Point[] BasePointPlayer3 { get; }
        public Point[] BasePointPlayer4 { get; }

        public Point[] FinishPointPlayer1 { get; }
        public Point[] FinishPointPlayer2 { get; }
        public Point[] FinishPointPlayer3 { get; }
        public Point[] FinishPointPlayer4 { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="width">Wysokość mapy</param>
        /// <param name="height">Szerokość mapy</param>
        public GameBoard(int width , int height)
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

            ///palyer 1 //////////////////////////////////////////////////////
            // BasePlayer1
             BasePointPlayer1[0] = new Point(width, height);
             BasePointPlayer1[1] = new Point(width * 2, height);
             BasePointPlayer1[2] = new Point(width, height*2);
             BasePointPlayer1[3] = new Point(width*2, height * 2);
            //StartPointPlayer1
            StartPointPlayer1 = new Point(width, height*5);
            //FinishPointPlayer1
            FinishPointPlayer1[0] = new Point(width*2, height*6);
            FinishPointPlayer1[1] = new Point(width*3, height*6);
            FinishPointPlayer1[2] = new Point(width*4, height*6);
            FinishPointPlayer1[3] = new Point(width*5, height*6);

            ///palyer 2 //////////////////////////////////////////////////////
            //StartPointPlayer2
            StartPointPlayer2 = new Point(width*7, height );
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
            //StartPointPlayer3
            StartPointPlayer3 = new Point(width*5, height*11);
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
            //StartPointPlayer4
            StartPointPlayer4 = new Point(width*11, height*7);
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



            StartPointPlayer1 = new Point(width, height * 5);

           

            PathPoint[0] = new Point(width * 7, height);
            PathPoint[1] = new Point(width * 7, height*2);
            PathPoint[2] = new Point(width * 7, height * 3);
            PathPoint[3] = new Point(width * 7, height * 4);
            PathPoint[4] = new Point(width * 7, height * 5);
            PathPoint[5] = new Point(width * 8, height * 5);
            PathPoint[6] = new Point(width * 9, height * 5);
            PathPoint[7] = new Point(width * 10, height * 5);
            PathPoint[8] = new Point(width * 11, height * 5);
            PathPoint[9] = new Point(width * 11, height * 6);
            PathPoint[10] = new Point(width * 11, height * 7);
            PathPoint[11] = new Point(width * 10, height * 7);
            PathPoint[12] = new Point(width * 9, height * 7);
            PathPoint[13] = new Point(width * 8, height * 7);
            PathPoint[14] = new Point(width * 7, height * 7);
            PathPoint[15] = new Point(width * 7, height * 8);
            PathPoint[16] = new Point(width * 7, height * 9);
            PathPoint[17] = new Point(width * 7, height * 10);
            PathPoint[18] = new Point(width * 7, height * 11);
            PathPoint[19] = new Point(width * 6, height * 11);
            PathPoint[20] = new Point(width * 5, height * 11);
            PathPoint[21] = new Point(width * 5, height * 10);
            PathPoint[22] = new Point(width * 5, height * 9);
            PathPoint[23] = new Point(width * 5, height * 8);
            PathPoint[24] = new Point(width * 5, height * 7);
            PathPoint[25] = new Point(width * 4, height * 7);
            PathPoint[26] = new Point(width * 3, height * 7);
            PathPoint[27] = new Point(width * 2, height * 7);
            PathPoint[28] = new Point(width , height * 7);
            PathPoint[29] = new Point(width , height * 6);
            PathPoint[30] = new Point(width , height * 5);
            PathPoint[31] = new Point(width * 2, height * 5);
            PathPoint[32] = new Point(width * 3, height * 5);
            PathPoint[33] = new Point(width * 4, height * 5);
            PathPoint[34] = new Point(width * 5, height * 5);
            PathPoint[35] = new Point(width * 5, height * 4);
            PathPoint[36] = new Point(width * 5, height * 3);
            PathPoint[37] = new Point(width * 5, height * 2);
            PathPoint[38] = new Point(width * 5, height );
            PathPoint[39] = new Point(width * 6, height );
            
        }





    }
}