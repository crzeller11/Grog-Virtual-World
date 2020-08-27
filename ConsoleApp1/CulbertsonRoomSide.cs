using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CulbertsonRoomSide
    {
        public static void North()
        {
            Console.WriteLine("You go to the north side of the room where you see a large table with scraps of cookies and coffee stains. The table is covered in a beautiful " +
                        "blue lace tablecloth that drapes to the floor.");
            while (true)
            {
                string userCommand = Console.ReadLine();
                if (userCommand == "go south")
                {
                    break;
                }
                else if (userCommand == "look cookies" || userCommand == "look coffee")
                {
                    Console.WriteLine("These cookies do not look very good to eat. Plus, there's no hot coffee left! This must've been left here quite a while ago...");
                }
                else if (userCommand == "look tablecloth")
                {
                    Console.WriteLine("You crouch down and decide to lift the tablecloth... maybe there's something under here? Unfortunately, you turn up dry. " +
                        "All that lives under this table is a stale cookie with one bite taken out of it. When you look closer, you notice that the bite is much " +
                        "larger than that of a human... better get moving before things get dangerous.");
                }
                else
                {
                    Console.WriteLine(Narrative.NotValid);
                }
            }
            
        }

        public static void East()
        {
            Console.WriteLine("You go to the east side of the room and see a beautiful bay window. On the sill is a box...");

            while (true)
            {
                string userCommand = Console.ReadLine();
                if (userCommand == "go west")
                {
                    break;
                }
                else if (userCommand == "look box")
                {
                    Console.WriteLine("You open up the box and see a rosary and a copy of last Sunday's sermon. There's a line that's been highlighted:" +
                        "\n'To seek confession, please approach the confessional and start with 'Hello Father.''" +
                        "\nHmmm, maybe this will be useful later on. Better keep it in mind.");
                }
                else
                {
                    Console.WriteLine(Narrative.NotValid);
                }
            }

        }

        public static Flashlight West(Flashlight userFlashlight)
        {
            Console.WriteLine("You go to the west side of the room and you see a large couch. One of the cushions is slightly lifted, maybe something is under there...");
            while (true)
            {
                string userCommand = Console.ReadLine();
                if (userCommand == "go east")
                {
                    break;
                }
                // FIXME: you can't look cushions for a second time? 
                else if (userCommand == "look cushion" || userCommand == "look couch")
                {
                    Console.WriteLine("You lift up the cushion of the couch and..." +
                        "\n\nTHERE THEY ARE!! The two batteries you need to power the flashlight, what luck!");
                    Console.WriteLine(Narrative.Lightbulb);
                    userFlashlight.Batteries = true;
                    return userFlashlight;
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