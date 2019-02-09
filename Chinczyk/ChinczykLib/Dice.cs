using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    /// <summary>
    /// Klasa definiująca kostkę do gry
    /// </summary>
    public class Dice : IDice
    {
        /// <summary>
        /// Właściwość przechowująca ścieżkę do zdjęcia kostki
        /// </summary>
        public string ImgPath { get; private set; }
        /// <summary>
        /// Właściwość przechowująca wartość (ilość oczek) kostki
        /// </summary>
        public int Value { get; private set; }  // zakres wartości to 1-6

        /// <summary>
        ///  Metoda ustawiająca ścieżkę do zdjęcia z odpowiednią wartością na kostce
        /// </summary>
        private void SetImgPath()
        {
            string path;
            switch (Value)
            {
                case 1:
                    path = "";
                    break;
                case 2:
                    path = "";
                    break;
                case 3:
                    path = "";
                    break;
                case 4:
                    path = "";
                    break;
                case 5:
                    path = "";
                    break;
                case 6:
                    path = "";
                    break;
                default:
                    path = "";
                    break;
            }
            ImgPath = path;
        }
        /// <summary>
        /// Metoda symulująca rzut kostką (losowy wybór wartości kostki)
        /// </summary>
        public void Roll()
        {
            Random random = new Random();
            Value = random.Next(1, 7);  // ustawienie losowej wartości kostki od 1 do 6
            SetImgPath();
        }
    }
}
