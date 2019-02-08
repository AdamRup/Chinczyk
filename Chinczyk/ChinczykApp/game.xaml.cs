using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ChinczykLib;


namespace ChinczykApp
{
    /// <summary>
    /// Logika interakcji dla klasy game.xaml
    /// </summary>
    public partial class game : Window
    {
        GameModel gameModel;


        public game()
        {
            InitializeComponent();
            int numberHumanPlayer=0;
            var windowNewGame = new newGame();
            ;

            //sprawdzenie checkboxow , ustalwnie ilu mamy ludzkich graczy , zawsze bedzie przynajmniej jeden gracz//to do nie działa ,sprawdzanie checboxow nie dziła 
            if (windowNewGame.playerOneCheckBox.IsChecked.Value == true)
                numberHumanPlayer++;
            if (windowNewGame.playerTwoCheckBox.IsChecked.Value == true)
                numberHumanPlayer++;
            if (windowNewGame.playerThreeCheckBox.IsChecked.Value == true)
                numberHumanPlayer++;
            if (windowNewGame.playerFourCheckBox.IsChecked.Value == true)
                numberHumanPlayer++;

            
            ////////////////////////////////////////////////////////////////

            //stworzenie modelu gry 
            gameModel = new GameModel(1, "kamil", "kuba", "janusz" , "Paweł");

            //wyświetlanie planszy////////////////////
            for (int i = 0; i < gameModel.gameBoard.PathPoint.Length; i++)
            {
                addImage(@"images\field.png", 50, 50, new Thickness(gameModel.gameBoard.PathPoint[i].X + 15, gameModel.gameBoard.PathPoint[i].Y + 15, 0, 0));
            }
            


            for (int i = 0; i < 4; i++)
            {
                addImage(@"images\p1FinishField.png", 50, 50, new Thickness(gameModel.gameBoard.BasePointPlayer1[i].X + 15, gameModel.gameBoard.BasePointPlayer1[i].Y + 15, 0, 0));
                addImage(@"images\p2FinishField.png", 50, 50, new Thickness(gameModel.gameBoard.BasePointPlayer2[i].X + 15, gameModel.gameBoard.BasePointPlayer2[i].Y + 15, 0, 0));
                addImage(@"images\p3FinishField.png", 50, 50, new Thickness(gameModel.gameBoard.BasePointPlayer3[i].X + 15, gameModel.gameBoard.BasePointPlayer3[i].Y + 15, 0, 0));
                addImage(@"images\p4FinishField.png", 50, 50, new Thickness(gameModel.gameBoard.BasePointPlayer4[i].X + 15, gameModel.gameBoard.BasePointPlayer4[i].Y + 15, 0, 0));

                addImage(@"images\p1FinishField.png", 50, 50, new Thickness(gameModel.gameBoard.FinishPointPlayer1[i].X + 15, gameModel.gameBoard.FinishPointPlayer1[i].Y + 15, 0, 0));
                addImage(@"images\p2FinishField.png", 50, 50, new Thickness(gameModel.gameBoard.FinishPointPlayer2[i].X + 15, gameModel.gameBoard.FinishPointPlayer2[i].Y + 15, 0, 0));
                addImage(@"images\p3FinishField.png", 50, 50, new Thickness(gameModel.gameBoard.FinishPointPlayer3[i].X + 15, gameModel.gameBoard.FinishPointPlayer3[i].Y + 15, 0, 0));
                addImage(@"images\p4FinishField.png", 50, 50, new Thickness(gameModel.gameBoard.FinishPointPlayer4[i].X + 15, gameModel.gameBoard.FinishPointPlayer4[i].Y + 15, 0, 0));


            }

            addImage(@"images\p1FinishField.png", 50, 50, new Thickness(gameModel.gameBoard.StartPointPlayer1.X + 15, gameModel.gameBoard.StartPointPlayer1.Y + 15, 0, 0));
            addImage(@"images\p2FinishField.png", 50, 50, new Thickness(gameModel.gameBoard.StartPointPlayer2.X + 15, gameModel.gameBoard.StartPointPlayer2.Y + 15, 0, 0));
            addImage(@"images\p3FinishField.png", 50, 50, new Thickness(gameModel.gameBoard.StartPointPlayer3.X + 15, gameModel.gameBoard.StartPointPlayer3.Y + 15, 0, 0));
            addImage(@"images\p4FinishField.png", 50, 50, new Thickness(gameModel.gameBoard.StartPointPlayer4.X + 15, gameModel.gameBoard.StartPointPlayer4.Y + 15, 0, 0));

            diceButton.Margin = new Thickness(gameModel.gameBoard.dicePoint.X + 15, gameModel.gameBoard.dicePoint.Y + 15, 0, 0);
            Player1Name.Margin = new Thickness(gameModel.gameBoard.NamePlayer1Point.X + 15, gameModel.gameBoard.NamePlayer1Point.Y + 15, 0, 0);
            Player2Name.Margin = new Thickness(gameModel.gameBoard.NamePlayer2Point.X + 15, gameModel.gameBoard.NamePlayer2Point.Y + 15, 0, 0);
            Player3Name.Margin = new Thickness(gameModel.gameBoard.NamePlayer3Point.X + 15, gameModel.gameBoard.NamePlayer3Point.Y + 30, 0, 0);
            Player4Name.Margin = new Thickness(gameModel.gameBoard.NamePlayer4Point.X + 15, gameModel.gameBoard.NamePlayer4Point.Y + 30, 0, 0);

            ///////////////////////////////////////////////



            //aktualizacja pionków na mapie , zmienienie położnia - wyswietlanie
            UpdatePawn();

            ///wyswietlanie nazw graczy
            Player1Name.Content = gameModel.players[0].Name;
            Player2Name.Content = gameModel.players[1].Name;
            Player3Name.Content = gameModel.players[2].Name;
            Player4Name.Content = gameModel.players[3].Name;

           
        }
       
       

      

        




        /// <summary>
        /// Funkcja dodająca zdjecie do grida 
        /// </summary>
        /// <param name="src">scieżka do zdjecia</param>
        /// <param name="width">wysokość zdjecia</param>
        /// <param name="hight">szerokosść zdjecia</param>
        /// <param name="margin">obiek thinkness który zawiera marginesy </param>
        public void addImage(string src, int width, int hight, Thickness margin , string name = null)
        {



            // Tworzenie zdjecia
            Image myImage = new Image();
            myImage.Width = width;
            myImage.Height = hight;
            // Wczytywnie scieżki do zdjecia 
            BitmapImage myBitmapImage = new BitmapImage();
            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(src);

            //myBitmapImage.DecodePixelWidth = 200;
            myBitmapImage.EndInit();
            //ustawianie scieżki do zdjecia
            myImage.Source = myBitmapImage;
            myImage.Margin = margin;
            myImage.HorizontalAlignment = 0;
            myImage.VerticalAlignment = 0;

            //dodawanie nazw
            if(name != null)
            myImage.Name = name;

            //dodawanie do grida
            myGrid.Children.Add(myImage);
        }


     




        private void DiceButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
        /// <summary>
        /// wywołane podczas klikniecia na kostkę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiceButton_Click_1(object sender, RoutedEventArgs e)
        {
            ////wylosowanie liczby
            gameModel.dice.Roll();
            diceButton.IsEnabled = false;
            //wysietlrnie wylosowanej liczby na kosce
            diceButton.Content = gameModel.dice.Value.ToString();
            // aktualizacja pola IsActive które przechowuje wrtość odpowiedzialną za to czy pionek może się poruszyć - true , w przeciwnym razie false 
            gameModel.UpdatePawnIsActive(gameModel.GetNextPlayer);

           
            ///ustawienie tych przyciskow które gracz nie może poruszyć na nieaktywne
             for (int i = 1; i < 5; i++)
                {
                    for (int j = 1; j < 5; j++)
                    {

                        string s = $"pl{i}{j}";
                        object wantedNode = myGrid.FindName(s);
                        if (wantedNode is Button)
                        {
                            Button Button = (Button)wantedNode;

                            if (gameModel.players[i - 1].pawns[j - 1].IsActive == true)
                            {
                                Button.IsEnabled = true;

                            }
                            else
                            {
                                Button.IsEnabled = false;

                            }
                        }

                    }
                }

                /// wywoływne wtedy gdy gracz nie posiada żadnego możliwego ruchu , przechodzi do następnego gracza
                if (!gameModel.IsAnymove())
                {
                    if (gameModel.GetNextNExtPlayer is HumanPlayer)
                    {
                    gameModel.NextPlayer();
                    }
                    else
                    {

                    gameModel.NextPlayer();
                    gameModel.NextRound();

                    }
                diceButton.IsEnabled = true;
            }
        }
        /// <summary>
        /// wywołanie podczas klikniecia w pionek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pl11_Click(object sender, RoutedEventArgs e)
        { 
                Button clickedButton = (Button)sender;
                int numberpown = int.Parse(clickedButton.Name.Last().ToString());
             

            if (diceButton.IsEnabled == false)
            {



                // sprawdzanie czy gra nie się już skończyła
                if (!gameModel.NextRound(numberpown))
                  {
                    //zamykanie okna gry i wyświetlenie nazyw zwycięzcy//to do
                      new End().Show();
                      new End().WinerName.Content = gameModel.Winer.Name;
                      this.Close();

                  }
                 //sprzwdzenie jakiego typu jest nastepny gracz i wywołanie odpowiedniej metody
                if (gameModel.GetNextPlayer is HumanPlayer)
                {
                    diceButton.IsEnabled = true;
                }
                else
                {
                   
                    gameModel.NextRound();
                }
            }
            ///ustawienie wszystkich przycisków na nieaktywne
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {

                    string s = $"pl{i}{j}";
                    object wantedNode = myGrid.FindName(s);
                    if (wantedNode is Button)
                    {
                        Button Button = (Button)wantedNode;

                        
                            Button.IsEnabled = true;

                        
                    }

                }
            }

            
            UpdatePawn();

        }


        /// <summary>
        ///   //aktualizacja pionków na mapie , zmienienie położnia - wyswietlanie
        /// </summary>
        public void UpdatePawn()
            {
                pl11.Margin = new Thickness(gameModel.players[0].pawns[0].Position.X + 15, gameModel.players[0].pawns[0].Position.Y + 15, 0, 0);
                pl12.Margin = new Thickness(gameModel.players[0].pawns[1].Position.X + 15, gameModel.players[0].pawns[1].Position.Y + 15, 0, 0);
                pl13.Margin = new Thickness(gameModel.players[0].pawns[2].Position.X + 15, gameModel.players[0].pawns[2].Position.Y + 15, 0, 0);
                pl14.Margin = new Thickness(gameModel.players[0].pawns[3].Position.X + 15, gameModel.players[0].pawns[3].Position.Y + 15, 0, 0);

                pl21.Margin = new Thickness(gameModel.players[1].pawns[0].Position.X + 15, gameModel.players[1].pawns[0].Position.Y + 15, 0, 0);
                pl22.Margin = new Thickness(gameModel.players[1].pawns[1].Position.X + 15, gameModel.players[1].pawns[1].Position.Y + 15, 0, 0);
                pl23.Margin = new Thickness(gameModel.players[1].pawns[2].Position.X + 15, gameModel.players[1].pawns[2].Position.Y + 15, 0, 0);
                pl24.Margin = new Thickness(gameModel.players[1].pawns[3].Position.X + 15, gameModel.players[1].pawns[3].Position.Y + 15, 0, 0);

                pl31.Margin = new Thickness(gameModel.players[2].pawns[0].Position.X + 15, gameModel.players[2].pawns[0].Position.Y + 15, 0, 0);
                pl32.Margin = new Thickness(gameModel.players[2].pawns[1].Position.X + 15, gameModel.players[2].pawns[1].Position.Y + 15, 0, 0);
                pl33.Margin = new Thickness(gameModel.players[2].pawns[2].Position.X + 15, gameModel.players[2].pawns[2].Position.Y + 15, 0, 0);
                pl34.Margin = new Thickness(gameModel.players[2].pawns[3].Position.X + 15, gameModel.players[2].pawns[3].Position.Y + 15, 0, 0);

                pl41.Margin = new Thickness(gameModel.players[3].pawns[0].Position.X + 15, gameModel.players[3].pawns[0].Position.Y + 15, 0, 0);
                pl42.Margin = new Thickness(gameModel.players[3].pawns[1].Position.X + 15, gameModel.players[3].pawns[1].Position.Y + 15, 0, 0);
                pl43.Margin = new Thickness(gameModel.players[3].pawns[2].Position.X + 15, gameModel.players[3].pawns[2].Position.Y + 15, 0, 0);
                pl44.Margin = new Thickness(gameModel.players[3].pawns[3].Position.X + 15, gameModel.players[3].pawns[3].Position.Y + 15, 0, 0);
            }

    }
}
