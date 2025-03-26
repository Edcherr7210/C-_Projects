using System;

namespace Tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            Game play = new Game();

            while (playing)
            {
                Console.Clear();
                play.GetBoard();
                play.PlayerMove();
                playing = play.CheckWinner();
                if(playing == true)
                {
                    playing = play.CheckTie();
                }

                
                play.ComputerMove();
                play.GetBoard();
                playing = play.CheckWinner();
                if(playing == true)
                {
                    playing = play.CheckTie();
                }
                              
            }
            Console.Clear();
            play.GetBoard();
        }
    }
}