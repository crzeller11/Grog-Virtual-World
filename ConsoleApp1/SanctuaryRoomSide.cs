using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SanctuaryRoomSide
    {
        public static Flashlight North(Flashlight userFlashlight)
        {
            Console.WriteLine("You go to the north side of the room and you see the altar. There is a lectern with a bible on it, a large wooden crucifix, and a bouquet of flowers.");
            while (true)
            {
                string userCommand = Console.ReadLine();
                if (userCommand == "look lectern")
                {
                    Console.WriteLine("You walk over to the lectern. You hear a quiet stirring at the back of the sanctuary, better get moving. Then, you notice a " +
                        "shelf lower on the podium. You crouch down, and put your hand into the hole... THERE IT IS! " +
                        "\n\nYOU FOUND THE LIGHTBULB! Fantastic work.");
                    userFlashlight.Bulb = true;
                    return userFlashlight;
                }
                else if (userCommand == "go south")
                {
                    break;
                }
                else if (userCommand == "look bible")
                {
                    Console.WriteLine("You notice that the bible is open to Samuel 1:17, the story of David and Goliath. Coincedence? Who will you be?");
                }
                else
                {
                    Console.WriteLine(Narrative.NotValid);
                }
            }
            return userFlashlight;
        }
        public static void South()
        {
            Console.WriteLine("You go the south side of the sanctuary, walking along the pews, constantly checking behind you in case Grog is lurking..." +
                "\nYou eventually reach the back of the sanctuary and enter the narthex. There's a mural on the wall, a few wooden chairs, and pictures of the congregation.");
            while (true)
            {
                string userCommand = Console.ReadLine();
                if (userCommand == "go north")
                {
                    break;
                }
                else if (userCommand == "look mural")
                {
                    Console.WriteLine("Beautiful artwork, dated from 1914.");
                }
                else if (userCommand == "look chair" || userCommand == "look chairs")
                {
                    Console.WriteLine("That is MAHOGANY! Please be careful.");
                }
                else if (userCommand == "look picture" || userCommand == "look pictures")
                {
                    Console.WriteLine("Looks like they have a really big congregation.");
                }
                else
                {
                    Console.WriteLine(Narrative.NotValid);
                }
            }

        }

        public static void West()
        {
            Console.WriteLine("You go the west side of the sanctuary, walking towards the big stained glass windows. As you get to the western edge of the pews, you notice the " +
                "baptismal font and a bookcase.");
            while (true)
            {
                string userCommand = Console.ReadLine();
                if (userCommand == "go east")
                {
                    break;
                }
                else if (userCommand == "look font" || userCommand == "look baptismal")
                {
                    Console.WriteLine("You walk over closer to the baptismal font to see that it is filled with holy water. Sure enough, there is a small pitcher of holy water below " +
                        "the basin.");
                }
                else if (userCommand == "look bookcase")
                {
                    Console.WriteLine("The bookcase is filled with an array of very decrepit books, all at least 500 pages in length. You pull one out, it's a book of hymnals. " +
                        "One of the hyymnals is bookmarked. It's a Chirstmas song, tells of the star that led the three kings to Mary and Joeseph. Strangely, there is a line " +
                        "in the song that has ben underlined: 'The king knew that to find the SOURCE OF LIGHT, he needed to go NORTH." +
                        "Hmmm, is this a coincedence, or a clue?");
                }
                else if (userCommand == "look window" || userCommand == "look glass" || userCommand == "look stained")
                {
                    Console.WriteLine("You peer upwards towards the massive stained glass windows. There are beautiful depictions of many stories from the bible, and an " +
                        "endless array of beautiful colors, although they appear muted in the absence of light. This reminds you of your objective: find the flashlight. " +
                        "You'd better get a move on, I think I just heard something coming from the north side of the sanctuary...");
                }
                else
                {
                    Console.WriteLine(Narrative.NotValid);
                }
            }

        }
    }
}
