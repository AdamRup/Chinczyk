using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinczykLib
{
    /// <summary>
    /// Klasa definiująca model gry
    /// </summary>
    public class GameModel
    {
        /// <summary>
        /// Właściwość przechowująca tablicę wszystkich graczy
        /// </summary>
        public Player[] players { get; }
        /// <summary>
        /// Właściwość przechowująca planszę do gry
        /// </summary>
        public GameBoard gameBoard { get; }
        /// <summary>
        /// Właściwość przechowująca kostkę do gry
        /// </summary>
        public Dice dice { get; }
        private int count =-1;
        /// <summary>
        /// Właściwość przechowująca gracza-zwycięzcę gry
        /// </summary>
        public Player Winer { get; private set; }
        /// <summary>
        /// Właściwość przechowująca aktualnie grającego gracza
        /// </summary>
        public Player CurrentPlayer { get; private set; }
        /// <summary>
        /// Właściwość przechowująca kolejnego gracza,który będzie wykonywał ruch
        /// </summary>
        public Player GetNextPlayer { get { return players[(count+1) % players.Length]; } }
        /// <summary>
        /// Właściwość przechowująca drugiego w kolejności gracza, który będzie wykonywał ruch
        /// </summary>
        public Player GetNextNExtPlayer { get { return players[(count + 2) % players.Length]; } }

        /// <summary>
        /// Konstruktor obiektu gamemodel
        /// </summary>
        /// <param name="numberHumanPlayer">ilośc graczy ludzkich</param>
        /// <param name="Player1Name">imie gracza 1</param>
        /// <param name="Player2Name">imie gracza 2 </param>
        /// <param name="Player3Name">imie gracza 3</param>
        /// <param name="Player4Name">imie gracza 4</param>
        public GameModel(int numberHumanPlayer, string Player1Name="" , string Player2Name="" , string Player3Name ="" , string Player4Name = "" )
        {
            ///tworzenie odpowiedniej ilości graczy ludzkich jak i komputerów
            gameBoard = new GameBoard(700, 700);
            dice = new Dice();
            players = new Player[4];
            players[0] = new HumanPlayer(Player1Name, 1, gameBoard.BasePointPlayer1, gameBoard.PathPlayer1, gameBoard.StartPointPlayer1, dice);
            players[1] = new HumanPlayer(Player2Name, 2, gameBoard.BasePointPlayer2, gameBoard.PathPlayer2, gameBoard.StartPointPlayer2, dice);
            players[2] = new HumanPlayer(Player3Name, 3, gameBoard.BasePointPlayer3, gameBoard.PathPlayer3, gameBoard.StartPointPlayer3, dice);
            players[3] = new HumanPlayer(Player4Name, 4, gameBoard.BasePointPlayer4, gameBoard.PathPlayer4, gameBoard.StartPointPlayer4, dice);

            
                if(numberHumanPlayer <= 3)
                    players[3] = new ComputerPlayer( 4, gameBoard.BasePointPlayer4, gameBoard.PathPlayer4, gameBoard.StartPointPlayer4, dice);
                if (numberHumanPlayer <= 2)
                    players[2] = new ComputerPlayer(3, gameBoard.BasePointPlayer3, gameBoard.PathPlayer3, gameBoard.StartPointPlayer3, dice);
                if (numberHumanPlayer <= 1)
                    players[1] = new ComputerPlayer(2, gameBoard.BasePointPlayer2, gameBoard.PathPlayer2, gameBoard.StartPointPlayer2, dice);
            
        }

            
           
           


        
        
     
        /// <summary>
        /// funkcja nowa runda dla gracza komputera
        /// </summary>
        /// <returns>Jeśli jakiś gracz wygrał zwraca fałsz w przeciwnym wypadku prawde</returns>
        public bool  NextRound()
        {

            System.Threading.Thread.Sleep(10);
            //sprawdzenie czy gracz jest odpowiedniego typu
            if (NextPlayer() is ComputerPlayer)
            {
                ComputerPlayer computerPlayer = CurrentPlayer as ComputerPlayer;
                //losowanie liczby
               
                dice.Roll();
                // aktualizacja pola IsActive które przechowuje wrtość odpowiedzialną za to czy pionek może się poruszyć - true , w przeciwnym razie false 
                UpdatePawnIsActive(computerPlayer);
                computerPlayer.Play();
               
            }

            //jesli następny gracz jest typu ComputerPlayer wywołanie ponownie tej metody dla nastepnego gracza 
            if (GetNextPlayer is ComputerPlayer && (!IsFinish()) && Winer is null)
                NextRound();
            //sprawdzenie czy gra nie dobiegła konca
            if (IsFinish())
                return false;
            return true;

            
        }


        /// <summary>
        /// funkcja nowa runda dla gracza komputera
        /// </summary>
        /// <param name="idPown"> numer pionka</param>
        /// <returns>Jeśli jakiś gracz wygrał zwraca fałsz w przeciwnym wypadku prawde</returns>
        public bool NextRound(int idPown)
        {


            System.Threading.Thread.Sleep(10);
            if (NextPlayer() is HumanPlayer)
            {

                HumanPlayer humanPlayer = CurrentPlayer as HumanPlayer ;
                humanPlayer.MovePawn(humanPlayer.SelectPawn(idPown));

            }

            //jesli następny gracz jest typu ComputerPlayer wywołanie ponownie  metody NextRound()  dla nastepnego gracza 
            if (GetNextPlayer is ComputerPlayer && (!IsFinish()) && Winer is null)
                NextRound();
            //sprawdzenie czy gra nie dobiegła konca
            if (IsFinish())
                return false;
            return true;


        }

        /// <summary>
        /// metoda która zwraca i  zapisuje do zmienej nastepnego gracza
        /// </summary>
        /// <returns>zwraca następnego gracza</returns>
        public Player NextPlayer()
        {
            count++;
            CurrentPlayer = players[count % players.Length];
            return players[count % players.Length];
        }
        /// <summary>
        // aktualizacja pola IsActive które przechowuje wrtość odpowiedzialną za to czy pionek może się poruszyć - true , w przeciwnym razie false 
        /// </summary>
        /// <param name="player"></param>
        public void UpdatePawnIsActive(Player player )
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                     if(players[i].Number == player.Number)
                     {
                        if(IsCollision(players[i].pawns[j]) )
                        {
                             players[i].pawns[j].IsActive = false;
                            
                        }
                         else
                        {
                            players[i].pawns[j].IsActive = true;
                        }
                         
                        
                     }
                     else
                     {
                         players[i].pawns[j].IsActive = false;
                     }
                     

                    
                }
            }
        }
    
        /// <summary>
        /// sprawdzenie czy po wykonaniu ruchu obiekt "pawn"  nie bedzie  na takiej samiej pozycji jaki inny
        /// </summary>
        /// <param name="pawn"> obiekt którym poruszamy </param>
        /// <returns> jeżeli obiekty będą na takich samych pozycjach zwraca prawde w innym przypadku fałsz</returns>
        private bool IsCollision(Pawn pawn )
        {
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (players[i].pawns[j].Position.Equals(pawn.ReturnNewPosition(dice.Value)))
                        return true;

                }
               

            }
           
                return false;

        }

  
        /// <summary>
        /// sprwadz czy na plaszy są obiekty którymi można jeszcze poruszyć
        /// </summary>
        /// <returns>jeżeli są obiekty którymi można poruszyc zwraca true w przeciwnym wypadku fałsz</returns>
        public bool IsAnymove()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (players[i].pawns[j].IsActive == true)
                    {
                        return true;
                    }
                  
                }

            }

            return false;
        }

        /// <summary>
        /// sprawdza czy gra dobiegła końca
        /// </summary>
        /// <returns>jeżeli tak zwraca true w przeciwnym wypadku fałsz</returns>
        public bool IsFinish()
        {


            if (include(players[0].pawns[0].Position, gameBoard.FinishPointPlayer1) && include(players[0].pawns[1].Position, gameBoard.FinishPointPlayer1) && include(players[0].pawns[2].Position, gameBoard.FinishPointPlayer1) && include(players[0].pawns[3].Position, gameBoard.FinishPointPlayer1))
            {
                Winer = players[0];
                return true;
            }
            if (include(players[1].pawns[0].Position, gameBoard.FinishPointPlayer2) && include(players[1].pawns[1].Position, gameBoard.FinishPointPlayer2) && include(players[1].pawns[2].Position, gameBoard.FinishPointPlayer2) && include(players[1].pawns[3].Position, gameBoard.FinishPointPlayer2))
            {
                Winer = players[1];
                return true;
            }
            if (include(players[2].pawns[0].Position, gameBoard.FinishPointPlayer3) && include(players[2].pawns[1].Position, gameBoard.FinishPointPlayer3) && include(players[2].pawns[2].Position, gameBoard.FinishPointPlayer3) && include(players[2].pawns[3].Position, gameBoard.FinishPointPlayer3))
            {
                Winer = players[2];
                return true;
            }
            if (include(players[3].pawns[0].Position, gameBoard.FinishPointPlayer4) && include(players[3].pawns[1].Position, gameBoard.FinishPointPlayer4) && include(players[3].pawns[2].Position, gameBoard.FinishPointPlayer4) && include(players[3].pawns[3].Position, gameBoard.FinishPointPlayer4))
            {
                Winer = players[3];
                return true;
            }
            return false;
               
             
          

           

        }
        /// <summary>
        /// sprawdza czy obiekt zawiera się w jakiejś tablicy
        /// </summary>
        /// <param name="p">obiekt punkt</param>
        /// <param name="tab">tablica obiektów punkt</param>
        /// <returns>jeżeli się zawiera zwraca prawde w preciwnym wypadku fałszfReturnNewPosition</returns>
        public bool include(Point p , Point[] tab)
        {
            for(int i =0; i<tab.Length; i++)
            {
                if (p.Equals(tab[i]))
                    return true;
            }

            return false;
        }
       

    
    }
}
