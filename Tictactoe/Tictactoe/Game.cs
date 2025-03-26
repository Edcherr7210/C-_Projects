using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tictactoe
{
    internal class Game
    {
        private char player = 'X';
        private char computer = 'O';
        private char[] spaces = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };        
        
        public void GetBoard()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + spaces[0] + "  |  " + spaces[1] + "  |  " + spaces[2] + "  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + spaces[3] + "  |  " + spaces[4] + "  |  " + spaces[5] + "  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + spaces[6] + "  |  " + spaces[7] + "  |  " + spaces[8] + "  ");
            Console.WriteLine("     |     |     ");
        }
        public void PlayerMove()
        {
            int select;
            bool valid = true;

            Console.Write("Where would you like select (1 - 9): ");
            select = Convert.ToInt32(Console.ReadLine());

            while (valid)
            {
                if (select > 9 || select < 1)
                {
                    valid = true;
                    Console.Write("Invalid Answer, Choose 1-9: ");
                    select = Convert.ToInt32(Console.ReadLine());
                }
                else if (spaces[select - 1] == player)
                {
                    valid = true;
                    Console.Write("You Already Chose That, Choose Again: ");
                    select = Convert.ToInt32(Console.ReadLine());
                }
                else if (spaces[select - 1] == computer)
                {
                    valid = true;
                    Console.Write("Spots Taken, Choose Again: ");
                    select = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    valid = false;
                }
            }

            if (spaces[select - 1] == ' ')
            {
                spaces[select - 1] = player;
            }
        }
        public void ComputerMove()
        {
            int select;
            bool valid = true;

            Random random = new Random();

            while (valid)
            {
                select = random.Next(1, 10);
                if (spaces[select - 1] == ' ')
                {
                    spaces[select - 1] = computer;
                    valid = false;
                }
                else if (spaces[select - 1] == player)
                {
                    valid = true;
                }
            }

        }
        public bool CheckWinner()
        {
            if ((spaces[0] != ' ') && (spaces[0] == spaces[1]) && (spaces[1] == spaces[2]))
            {
                if(spaces[0] == player)
                {
                    Console.WriteLine("You Won The Game!");
                    return false;
                }
                else
                {
                    Console.WriteLine("You Lost The Game!");
                    return false;
                }
            }
            else if ((spaces[3] != ' ') && (spaces[3] == spaces[4]) && (spaces[4] == spaces[5]))
            {
                if (spaces[3] == player)
                {
                    Console.WriteLine("You Won The Game!");
                    return false;
                }
                else
                {
                    Console.WriteLine("You Lost The Game!");
                    return false;
                }
            }
            else if ((spaces[6] != ' ') && (spaces[6] == spaces[7]) && (spaces[7] == spaces[8]))
            {
                if (spaces[6] == player)
                {
                    Console.WriteLine("You Won The Game!");
                    return false;
                }
                else
                {
                    Console.WriteLine("You Lost The Game!");
                    return false;
                }
            }
            else if ((spaces[0] != ' ') && (spaces[0] == spaces[3]) && (spaces[3] == spaces[6]))
            {
                if (spaces[0] == player)
                {
                    Console.WriteLine("You Won The Game!");
                    return false;
                }
                else
                {
                    Console.WriteLine("You Lost The Game!");
                    return false;
                }
            }
            else if ((spaces[1] != ' ') && (spaces[1] == spaces[4]) && (spaces[4] == spaces[7]))
            {
                if (spaces[1] == player)
                {
                    Console.WriteLine("You Won The Game!");
                    return false;
                }
                else
                {
                    Console.WriteLine("You Lost The Game!");
                    return false;
                }
            }
            else if ((spaces[2] != ' ') && (spaces[2] == spaces[5]) && (spaces[5] == spaces[8]))
            {
                if (spaces[2] == player)
                {
                    Console.WriteLine("You Won The Game!");
                    return false;
                }
                else
                {
                    Console.WriteLine("You Lost The Game!");
                    return false;
                }
            }
            else if ((spaces[0] != ' ') && (spaces[0] == spaces[4]) && (spaces[4] == spaces[8]))
            {
                if (spaces[0] == player)
                {
                    Console.WriteLine("You Won The Game!");
                    return false;
                }
                else
                {
                    Console.WriteLine("You Lost The Game!");
                    return false;
                }
            }
            else if ((spaces[2] != ' ') && (spaces[2] == spaces[4]) && (spaces[4] == spaces[6]))
            {
                if (spaces[2] == player)
                {
                    Console.WriteLine("You Won The Game!");
                    return false;
                }
                else
                {
                    Console.WriteLine("You Lost The Game!");
                    return false;
                }
            }
            return true;
        }
        public bool CheckTie()
        {
            for(int i = 0; i < 9; i++)
            {
                if (spaces[i] == ' ')
                    return true;
            }

            Console.WriteLine("It's A Tie!");
            return false;
        }
    }
}
