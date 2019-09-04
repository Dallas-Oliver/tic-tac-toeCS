using System;
using System.Linq;

namespace ticTacToe
{
    class Program
    {

        static string[] boardSpots = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static string player1, player2, score1 = "0", score2 = "0";
       

        

        static void Main(string[] args)
        {

            createPlayers();
            Console.WriteLine(" ");
            Console.WriteLine("Score {0} - {1}   {2} - {3}", player1, score1, player2, score2);
            displayBoard();
            Console.WriteLine(" ");
            
           
            playGame();
            


            Console.ReadLine();
        }

        static void takeTurn(string player, string piece)
        {
            
            Console.WriteLine("{0}'s turn. Choose a number between 1-9 that corresponds to the spot you want to take.", player);
            int choice = int.Parse(Console.ReadLine());

            if(boardSpots[choice] == "x" || boardSpots[choice] == "o")
            {
                Console.WriteLine("please choose a different spot");
                choice = int.Parse(Console.ReadLine());
                boardSpots[choice] = piece;
                displayBoard();
            } else
            {
                if(boardSpots.Contains(choice.ToString()))
                {
                    boardSpots[choice] = piece;
                    displayBoard();
                } else
                {
                    Console.WriteLine("please choose a number between 1-9");
                    choice = int.Parse(Console.ReadLine());
                    boardSpots[choice] = piece;
                    displayBoard();
                }
                
            }

        }

        static void playGame()
        {
            bool player1Turn = true;
            while(!playerHasWon())
            {
                if (player1Turn)
                {
                    takeTurn(player1, "x");
                    player1Turn = false;
                }
                else
                {
                    takeTurn(player2, "o");
                    player1Turn = true;
                }
            }
           
        }

        static void displayBoard()
        {
            Console.WriteLine(boardSpots[1] + "|" + boardSpots[2] + "|" + boardSpots[3]);
            Console.WriteLine(boardSpots[4] + "|" + boardSpots[5] + "|" + boardSpots[6]);
            Console.WriteLine(boardSpots[7] + "|" + boardSpots[8] + "|" + boardSpots[9]);

        }

        static void createPlayers()
        {
            Console.WriteLine("Player 1 enter your name:");
            player1 = Console.ReadLine();
            Console.WriteLine("Player 2 enter your name:");
            player2 = Console.ReadLine();
            Console.WriteLine("{0} has x's and {1} has o's", player1, player2);
        }

        static bool playerHasWon()
        {
            if(checkForLine())
            {
                Console.WriteLine("Game Over. would you like to play again? y/n");
                string choice = Console.ReadLine();
                
                if(choice == "y")
                {
                    resetBoard();
                    displayBoard();
                    playGame();
                    
                } else if(choice == "n")
                {
                    Console.WriteLine("Thanks for playing!");
                    
                }

                return true;
                
            } else
            {
                return false;
            }
        }

        static bool checkForLine()
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

            return false;

        }

        static bool isLine(int index0, int index1, int index2, string piece)
        {
            return boardSpots[index0] == piece && boardSpots[index1] == piece && boardSpots[index2] == piece;
            
        }

        static void resetBoard()
        {
            for (int i = 1; i < 10; i++) 
            {
                boardSpots[i] = i.ToString();
            }

            
        }


    }
}
