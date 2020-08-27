using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        /*
         FIXME:
            - Add ASCII art narrative variables to the story
                - Check if you can add colors to make this more interesting
            - allow user to start the clock
                - also allow user to select zen mode with no timer
            - In Culbertson Room west, can't look cushions twice for some reason?
            - tell user which directions they can go in when they enter a room
         */
        private static Stopwatch _gameTime = new Stopwatch();
        private static Flashlight _userFlashlight = new Flashlight();
        private static bool _playingGame = true;

        public static void CheckFlashlightCompleteness()
        {
            if (_userFlashlight.IsFlashlightComplete())
            {
                _gameTime.Stop();
                _playingGame = false;
            }
        }

        public static void TravelNorth()
        {
            _userFlashlight = Church.CulbertsonRoom(_userFlashlight);
            CheckFlashlightCompleteness();
        }

        public static void TravelSouth()
        {
            _userFlashlight = Church.Crypt(_userFlashlight);
            CheckFlashlightCompleteness();
        }

        public static void TravelEast()
        {
            Church.Cloisters();
        }

        public static void TravelWest()
        {
            _userFlashlight = Church.Sanctuary(_userFlashlight);
            CheckFlashlightCompleteness();
        }

        public static void TravelConfessional()
        {
            bool priestChoice = Church.Confessional();
            if (!priestChoice)
            {
                _gameTime.Stop();
                _playingGame = false;
            }
        }

        public static void TravelThroughChurch(string userCommand)
        {
            if (userCommand == "go north")
            {
                TravelNorth();
            }
            else if (userCommand == "go south")
            {
                TravelSouth();
            }
            else if (userCommand == "go east")
            {
                TravelEast();
            }
            else if (userCommand == "go west")
            {
                TravelWest();
            }
            else if (userCommand == "look time")
            {
                CheckTime();
            }
            else
            {
                Console.WriteLine(Narrative.NotValid);
                if (_gameTime.Elapsed.Minutes >= 15)
                {
                    TravelConfessional();
                }
            }
        }

        public static void CheckTime()
        {
            Console.WriteLine($"You still have {15 - _gameTime.Elapsed.Minutes} minutes to find Grog. Hurry!");
        }

        public static void DisplayGameEnd()
        {
            if (_gameTime.Elapsed.Minutes >= 15)
            {
                Console.WriteLine("Perhaps the priest will be more forgiving next time, thanks for playing.");
            }
            else if (_userFlashlight.IsFlashlightComplete())
            {
                Console.WriteLine(Narrative.EndGame);
                Console.WriteLine($"Congratulations! You beat grog, and it only took you {_gameTime.Elapsed.Minutes} minutes.");
            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(Narrative.GameIntroduction);

            // Prompt the user to decide if they're ready to start the clock
            _gameTime.Start();
            do
            {
                
                Console.WriteLine(Narrative.MainLobby);
                string userCommand = Console.ReadLine();
                TravelThroughChurch(userCommand);

            } while (_gameTime.Elapsed.Minutes < 15 && _playingGame);

            DisplayGameEnd();
        }
    }
}
