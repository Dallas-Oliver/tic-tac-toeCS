using System;

namespace ticTacToe
{
    class Program
    {

        static string[] boardSpots = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static string player1, player2, score1 = "0", score2 = "0";
        static bool gameWon = false;

        static void createBoard()
        {
            Console.WriteLine(boardSpots[0] + "|" + boardSpots[1] + "|" + boardSpots[2]);
            Console.WriteLine(boardSpots[3] + "|" + boardSpots[4] + "|" + boardSpots[5]);
            Console.WriteLine(boardSpots[6] + "|" + boardSpots[7] + "|" + boardSpots[8]);

        }

        static void Main(string[] args)
        {
            
            


            Console.WriteLine("Player 1 enter your name:");
            player1 = Console.ReadLine();
            Console.WriteLine("Player 2 enter your name:");
            player2 = Console.ReadLine();
            Console.WriteLine("{0} has x's and {1} has o's", player1, player2);

            if (gameWon == false)
            {
                createBoard();
                takeTurn(player1);

                if (playerHasWon())
                {


                    resetBoard();
                }    

                
            }




            Console.ReadLine();
        }

        static int takeTurn(string player)
        {
            
            Console.WriteLine("Score {0} - {1}   {2} - {3}", player1, score1, player2, score2);
            Console.WriteLine("{0} goes first. Make your move", player);
            int choice = int.Parse(Console.ReadLine());
            boardSpots[choice] = "x";
            createBoard();

            return choice;

        }

        static bool playerHasWon()
        {
            //check if "x" player has won
            //horizontal
          if(isLine(1, 2, 3, "x") ||
             isLine(4, 5, 6, "x") ||   
             isLine(7, 8, 9, "x") ||   
             //diagonal
             isLine(1, 5, 9, "x") ||          
             isLine(3, 5, 7, "x") ||
             //vertical
             isLine(1, 4, 7, "x") ||
             isLine(2, 5, 8, "x") ||
             isLine(3, 6, 9, "x") ||

            
             //check if "o" player has won
             //horizontal
             isLine(1, 2, 3, "o") ||          
             isLine(4, 5, 6, "o") ||          
             isLine(7, 8, 9, "o") ||  
             //diagonal
             isLine(1, 5, 9, "o") ||           
             isLine(3, 5, 7, "o") ||
             //vertical
             isLine(1, 4, 7, "o") ||
             isLine(2, 5, 8, "o") ||
             isLine(3, 6, 9, "o"))
            {
                return true;
            }





            {
                return true;
            }
           
            
                return false;
            






        }

        static bool isLine(int index0, int index1, int index2, string piece)
        {
            return boardSpots[index0] == piece && boardSpots[index1] == piece && boardSpots[index2] == piece;
            
        }


    }
}
