using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CryptRoomSide
    {
        public static void West()
        {
            Console.WriteLine("You walk over to the west side of the crypt. Wow, it is super dark and creepy in this room. Even after walking around in the dark church for a litte " +
                "while now, it's clear that you don't want to spend any more time here than is necessary. At the west side of the room is a gated area, you decide to enter it because " +
                "yopu see a small light coming from inside. Hopefully it isn't a trap. When you walk into the gated area, you see a small donation box to your left. There's a basket " +
                "of white candles next to it. There's also a small altar with one lit candle on it.");
            bool collectedCandle = false;
            while (true)
            {
                string userCommand = Console.ReadLine();
                if (userCommand == "go east")
                {
                    break;
                }
                else if (userCommand == "look box")
                {
                    Console.WriteLine("You get a bit closer to the donation box and candles and rifle around for 25 cents in your pocket. You pull out the shiny coin and slip it it " +
                        "the donation box. You pick up a candle.");
                    collectedCandle = true;
                }
                else if (userCommand == "look altar")
                {
                    if (collectedCandle)
                    {
                        Console.WriteLine("You take the candle you picked up at the donation box and light it with the flame of the altar candle. Suddenly, there's twice as much " +
                            "light in the room, and it no longer seems as unwelcoming. This reminds you of your plight: you must find the flashlight pieces quickly, then you can " +
                            "control even more light in this church.");
                    }
                    else
                    {
                        Console.WriteLine("It's a nice altar, wish there was some more light than just this one candle...");
                    }
                }
                else
                {
                    Console.WriteLine(Narrative.NotValid);
                }
            }
        }

        public static void South()
        {
            Console.WriteLine("You walk towards the south side of the Crypt and see a rather dusty wall. It's really dark over here...");
            while (true)
            {
                string userCommand = Console.ReadLine();
                if (userCommand == "go north")
                {
                    break;
                }
                else if (userCommand == "look wall")
                {
                    Console.WriteLine("It's and old dusty wall, doesn't appear to be much to see here...");
                }
                else
                {
                    Console.WriteLine(Narrative.NotValid);
                }
            }
        }

        public static Flashlight East(Flashlight userFlashlight)
        {
            Console.WriteLine("You wander over to the east side of the crypt and soon realize this is maybe the worst part of this room: the tombs. All along the last 10 " +
                "yards of the floor, and scaling the walls are small headstones of various people that were buried here. As you scan over the wall, you see one of the stones " +
                "is loose, protruding around 3 inches from the flush of the wall.");
            while (true)
            {
                string userCommand = Console.ReadLine();
                if (userCommand == "go west")
                {
                    break;
                }
                else if (userCommand == "look stone")
                {
                    Console.WriteLine("You REALLY don't want to touch this stone, I mean you're in a tomb for god's sake (pun intended). But, your curiosity gets the best of you. " +
                        "Besides, time really is of the essence. You reach up to grab the edges of the stone and slowly push it side to side. It can definitely be removed. " +
                        "\nThe suspense is killing you, so in one swift movement, you just rip the stone of out of the wall. It's so dark in here that you simply cannot see inside " +
                        "the hole you've just revealed. You just know that the only sensible thing to do at this point is really to walk away, but then you think about putting " +
                        "your hand inside of the hole...");
                    userCommand = Console.ReadLine();
                    if (userCommand == "walk away")
                    {
                        Console.WriteLine("You decide to walk away, no way you're putting your hand in a tomb.");
                        continue;
                    }
                    else if (userCommand == "look hole" || userCommand == "look tomb")
                    {
                        Console.WriteLine("You dare to be brave, and reach your hand into the hole you've opened. Your heartbeat starts racing as you reach closer and closer towards " +
                            "the darkness, but you know that you must keep going. As you stick your hand in, you feel spiderwebs coat your fingers. But, right as your about to yank out " +
                            "your hand, you feel it! " +
                            "\n\nYou found the handle of the flashlight!! CONGRATS!");
                        userFlashlight.Handle = true;
                        return userFlashlight;
                    }
                    else
                    {
                        Console.WriteLine(Narrative.NotValid);
                    }
                }
                else
                {
                    Console.WriteLine(Narrative.NotValid);
                }
            }
            return userFlashlight;
        }
    }
}
