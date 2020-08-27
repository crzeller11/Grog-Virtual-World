using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CloistersRoomSide
    {
        public static void North()
        {
            Console.WriteLine("You walk north along the beautiful valuted hallway, and see a lovely garden out to your right. There are roses blooming under the night sky." +
                "\nOnce you reach the most norther wy of the cloisters, you see an inscription in the stone.");
            while (true)
            {
                string userCommand = Console.ReadLine();
                if (userCommand == "look stone" || userCommand == "look inscription" || userCommand == "look writing")
                {
                    Console.WriteLine("You step forward to examine the inscription more carefully. ");
                   
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
        }

        public static void East()
        {
            Console.WriteLine("You walk east along the clositers and observe the beautiful limestone at your feet. When you look closer, you see something " +
                "strange on the bricks. Once you reach the wall, you look down and see a rosary strewn on the floor.");
            while (true)
            {
                string userCommand = Console.ReadLine();
                if (userCommand == "go west")
                {
                    break;
                }
                else if (userCommand == "look brick" || userCommand == "look bricks")
                {
                    Console.WriteLine("When you go to examine the brick more closely, you notice that there are some... scratch marks on it! There's some dusk" +
                        "in this area too, it looks like some sort of animal scratched this part of the limestone. Better keep moving, you wouldn't want to " +
                        "get any of those scratches.");
                } 
                else if (userCommand == "look rosary")
                {
                    Console.WriteLine("What a beautiful rosary! It smells like roses... that's sort of odd. There are small ruby beads on the strand, alternating" +
                        "with gold beads. Otherwise, there doesn't seem to be anything interesting about this rosary.");
                }
                else
                {
                    Console.WriteLine(Narrative.NotValid);
                }
            }
        }

        public static void South()
        {
            Console.WriteLine("You go to the south side of the cloisters and start seeing a pattern or differenly colored rocks, speckedled throguhout the limestone." +
                "Each rock is labeled with a small silver plaque. When you get to the end of the southern side, you notice one reddish rock with a plaque on it.");
            while (true) {
                string userCommand = Console.ReadLine();
                if (userCommand == "go north")
                {
                    break;
                }
                else if (userCommand == "look rock")
                {
                    Console.WriteLine("The rock is a beautiful red color, wonder where it's from?");
                }
                else if (userCommand == "look plaque")
                {
                    Console.WriteLine("You look closer at the plaque on the red rock. It says that this rock is originally from Jerusalem, and it was transported to" +
                        "by installed specifically in this church.");
                }
                else
                {
                    Console.WriteLine(Narrative.NotValid); 
                }
            }
        }
    }
}
