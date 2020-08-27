using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Church
    {

        public static Flashlight CulbertsonRoom(Flashlight userFlashlight)
        {
            /*
            North of the main lobby, this is where the batteries will be, hidden under the couch cusion
             */
            bool inRoom = true;
            Console.WriteLine("Welcome to the Culbertson room, the heart of life at this parish. Each Sunday morning, after the service, paritioners gather around the coffee " +
                "machine and the plates of cookies and go about their normal business. Little do they know about the monster that dwells here at night...");
            while (inRoom)
            {
                Console.WriteLine("You're in the center of the Culbertson room.");
                string userCommand = Console.ReadLine();
                if (userCommand == "go south")
                {
                    inRoom = false;
                }
                else if (userCommand == "go north")
                {
                    CulbertsonRoomSide.North();
                }
                else if (userCommand == "go east")
                {
                    CulbertsonRoomSide.East();
                }
                else if (userCommand == "go west")
                {
                    userFlashlight = CulbertsonRoomSide.West(userFlashlight);
                }
                else
                {
                    Console.WriteLine("Command has no effect.");
                }
            }
            return userFlashlight;
        }

        public static Flashlight Sanctuary(Flashlight userFlashlight)
        {
            /*
             South of the main lobby, there is nothing to find in the sanctuary 
             */
            bool inRoom = true;
            Console.WriteLine("Welcome to the Sanctuary, the holiest part of the church. There is both a sense of serenity and malice as you look at the darkness " +
                "pouring through the stained glass in front of you.");
            while (inRoom)
            {
                Console.WriteLine("You're in the center of the Sanctuary.");
                string userCommand = Console.ReadLine();
                if (userCommand == "go south")
                {
                    SanctuaryRoomSide.South();
                }
                else if (userCommand == "go north")
                {
                    userFlashlight = SanctuaryRoomSide.North(userFlashlight);
                }
                else if (userCommand == "go east")
                {
                    inRoom = false;
                }
                else if (userCommand == "go west")
                {
                    SanctuaryRoomSide.West();
                }
                else
                {
                    Console.WriteLine(Narrative.NotValid);
                }
            }
            return userFlashlight;
        }

        public static void Cloisters()
        {
            bool inRoom = true;
            Console.WriteLine("Welcome to the Cloisters, an outdoor hallway of beautiful valuted ceilings.");
            while (inRoom)
            {
                Console.WriteLine("Your in the center of the Cloisters.");
                string userCommand = Console.ReadLine();
                if (userCommand == "go north")
                {
                    CloistersRoomSide.North();
                }
                else if (userCommand == "go south")
                {
                    CloistersRoomSide.South();
                }
                else if (userCommand == "go east")
                {
                    CloistersRoomSide.East();
                }
                else if (userCommand == "go west")
                {
                    inRoom = false;
                }
                else
                {
                    Console.WriteLine(Narrative.NotValid);
                }
            }
        }

        public static Flashlight Crypt(Flashlight userFlashlight)
        {
            /*
             West of the main lobby, the handle is found inside of a.... broken grave??? Idk lol
             */
            bool inRoom = true;
            Console.WriteLine("Welcome to the Crypt, the spookiest part of the church. There is a really threatening scent down here, like some people come down here, " +
                "and never get the chance to return...");
            while (inRoom)
            {
                Console.WriteLine("You're in the center of the Crypt.");
                string userCommand = Console.ReadLine();
                if (userCommand == "go north")
                {
                    inRoom = false;
                }
                else if (userCommand == "go south")
                {
                    CryptRoomSide.South();
                }
                else if (userCommand == "go east")
                {
                    userFlashlight = CryptRoomSide.East(userFlashlight);
                }
                else if (userCommand == "go west")
                {
                    CryptRoomSide.West();
                }
                else
                {
                    Console.WriteLine(Narrative.NotValid);
                }
            }
            return userFlashlight;
        }

        public static bool Confessional()
        {
            Console.WriteLine("ARRGGGGHHHH!! You ran out of time and Grog caught you!!! If you walk to the confessional, perhaps the priest will give you a second change.");
            Console.WriteLine("You sheepishly saunter over to the confessional at the back of the sanctuary to plead your case. Type below what you'd like to say to justify more time.");
            string confession = Console.ReadLine();

            if (confession.ToLower().Contains("hello father"))
            {
                Console.WriteLine("I see you found the sermon earlier, blessed day! The priest has afforded you another chance. Play on, and catch Grog!!");
                return true;
            }
            else
            {
                Console.WriteLine("Too bad, the priest in his holy wisdom has decided to not give you another chance. Come back later.");
                return false;
            }
        }

    }

    
}
