using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    struct Player
    {
        public int _playerHealth;
        public string _playerName;
    }
    class Game
    {
        bool dead = false;
        Player player1;
        Player player2;
        void GetInput(out char input, string option1, string option2, string option3)
        {
            //Initialize input
            input = ' ';
            //Loop until the player enters a valid input
            while (input != '1' && input != '2' && input != '3' && input != '4')
            {
                Console.WriteLine("1." + option1);
                Console.WriteLine("2." + option2);
                Console.WriteLine("3." + option3);
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3')
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        void PrintStats(Player player)
        {
            Console.WriteLine("\n" + player._playerHealth);
            Console.WriteLine("Health: " + player._playerHealth);
        }

        void GetInput(out char input)
        {
            input = ' ';
            if (input != '1' && input != '2' && input != '3')
            {
                Console.WriteLine("Invalid Input");
            }
        }
        void GameEnd()
        {
            if (player1._playerHealth < player2._playerHealth)
            {
                Console.WriteLine("Player 2 Wins!!!");
                Console.Clear();
                return;
            }
            else if (player2._playerHealth < player1._playerHealth)
            {
                Console.WriteLine("Player 1 Wins!!!");
                Console.Clear();
                return;
            }
            Console.Clear();
        }
        void InitializeCharacters()
        {
            player1._playerName = "Player1";
            player1._playerHealth = 100;
            player2._playerName = "Player2";
            player2._playerHealth = 100;
        }
        public void Run()
        {
            InitializeCharacters();
            Start();
            while (dead == true)
            End();
        }
        public void Start()
        {
            Console.WriteLine("\nWelcome");
            // I want to make one player pick a number between one and four and have one of the numbers randomly cause an explosion which will make the player that picks it die..
            player1._playerHealth = 100;
            player2._playerHealth = 100;

            char input;
            Console.WriteLine("Player 1, pick a number");
            GetInput(out input, "1", "2", "3");
            if (input == '1')
            {
                Console.WriteLine("\nCongrats! You live!");
            }
            if (input == '2')
            {
                Console.WriteLine("\nWelp, it sucks to be you.. You became human confetti!");
                player1._playerHealth -= 10000;
            }
            if (input == '3')
            {
                Console.WriteLine("\nCongrats! You live!");
            }
            Console.Clear();

            GameEnd();

            Console.WriteLine("Player 2, pick a number");
            GetInput(out input, "1", "2", "3");
            if (input == '1')
            {
                Console.WriteLine("\nCongrats! You live!");
            }
            if (input == '2')
            {
                Console.WriteLine("\nWelp, it sucks to be you.. You became human confetti!");
                player2._playerHealth -= 10000;
            }
            if (input == '3')
            {
                Console.WriteLine("\nCongrats! You live!");
            }

            GameEnd();

            if (player1._playerHealth > 0 && player2._playerHealth > 0)
            {
                Console.WriteLine("On to round 2!");
            }

            Console.WriteLine("Player 1, pick a number");
            GetInput(out input, "1", "2", "3");
            if (input == '1')
            {
                Console.WriteLine("\nWell, you seemed to have been eviscerated.!");
                player1._playerHealth -= 10000;
            }
            if (input == '2')
            {
                Console.WriteLine("\nCongrats! You live!");
            }
            if (input == '3')
            {
                Console.WriteLine("\nCongrats! You live!");
            }
            Console.Clear();

            GameEnd();

            Console.WriteLine("Player 2, pick a number");
            GetInput(out input, "1", "2", "3");
            if (input == '1')
            {
                Console.WriteLine("\nYou seemed to have been eviscerated.!");
                player2._playerHealth -= 10000;
            }
            if (input == '2')
            {
                Console.WriteLine("\nCongrats! You live!");
            }
            if (input == '3')
            {
                Console.WriteLine("\nCongrats! You live!");
            }

            GameEnd();

            if (player1._playerHealth > 0 && player2._playerHealth > 0)
            {
                Console.WriteLine("On to round 3!?");
            }


                Console.WriteLine("Player 1, pick a number");
            GetInput(out input, "1", "2", "3");
            if (input == '1')
            {
                Console.WriteLine("\nCongrats! You live!");
            }
            if (input == '2')
            {
                Console.WriteLine("\nYou literally imploded?!");
                player1._playerHealth -= 10000;
            }
            if (input == '3')
            {
                Console.WriteLine("\nYou literally imploded?!");
                player1._playerHealth -= 10000;
            }
            Console.Clear();

            GameEnd();

            Console.WriteLine("Player 2, pick a number");
            GetInput(out input, "1", "2", "3");
            if (input == '1')
            {
                Console.WriteLine("\nYou literally imploded?!");
                player2._playerHealth -= 10000;
            }
            if (input == '2')
            {
                Console.WriteLine("\nCongrats! You live!");
            }
            if (input == '3')
            {
                Console.WriteLine("\nYou literally imploded?!");
                player2._playerHealth -= 10000;
            }

            GameEnd();

            if (player1._playerHealth <= 0)
            {
                Console.WriteLine("\nPlayer 2 Wins!!!");
                return;
            }
            else if (player2._playerHealth <= 0)
            {
                Console.WriteLine("\nPlayer 1 Wins!!!");
                return;
            }



        }
        public void End()
        {
            if (player1._playerHealth <= 0)
            {
                Console.WriteLine("Player 2 Wins!!!");
                return;
            }
            else if (player2._playerHealth <=0)
            {
                Console.WriteLine("Player 1 Wins!!!");
                return;
            }
        }
    }
}
