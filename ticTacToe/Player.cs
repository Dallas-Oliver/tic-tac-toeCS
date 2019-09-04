using System;
using System.Collections.Generic;
using System.Text;



namespace ticTacToe
{
    class Player
    {
        private string playerSymbol = "X";


        public void ChangePlayer()
        {
            if (playerSymbol =="X")
            {
                playerSymbol = "O";
            } else if(playerSymbol == "O")
            {
                playerSymbol = "X";
            }

        }
        
        public string takeTurn()
        {
            Console.WriteLine("Please choose a spot:");
            string spotChoice = Console.ReadLine();

            return spotChoice;
        }
        

    }
}
