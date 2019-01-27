using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    public class Dice
    {
        public string ImgPath { get; private set; }
        public int Value { get; private set; }  // zakres wartości to 1-6

        // ustawienie ścieżki do zdjęcia z odpowiednią wartością na kostce 
        private void SetImgPath()
        {
            string path;
            switch (Value)
            {
                case 1:
                    path = "";  //uzupełnić ścieżkę do zdjęcia z kostką
                    break;
                case 2:
                    path = "";  //uzupełnić ścieżkę do zdjęcia z kostką
                    break;
                case 3:
                    path = "";  //uzupełnić ścieżkę do zdjęcia z kostką
                    break;
                case 4:
                    path = "";  //uzupełnić ścieżkę do zdjęcia z kostką
                    break;
                case 5:
                    path = "";  //uzupełnić ścieżkę do zdjęcia z kostką
                    break;
                case 6:
                    path = "";  //uzupełnić ścieżkę do zdjęcia z kostką
                    break;
                default:
                    path = "";  //uzupełnić ścieżkę do zdjęcia z kostką
                    break;
            }
            ImgPath = path;
        }

        public void Roll()
        {
            Random random = new Random();
            Value = random.Next(1, 7);  // ustawienie losowej wartości kostki od 1 do 6
            SetImgPath();
        }
    }
}
