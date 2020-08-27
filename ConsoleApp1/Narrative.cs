using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class Narrative
    {
        public static string GameIntroduction =
            "Welcome! The game is Grog. You are dropped into an old  dark church, and Grog is on the move. " +
            "His objective is to catch you before you catch him. If you don't catch him in 15 minutes, then it's game over. " +
            "Grog can only be seen with light, so you'll need to assemble a flashlight to get him.You start in the main lobby of " +
            "the church, and the rooms extenuate out of this hallway. You can always return to the main lobby." +
            "\nThe only valid actions are 'go' and 'look.' Go can be used only with a cardinal direction, for example:" +
            "\ngo north" +
            "\nlook can be used with objects that you encounter in the church, for example:" +
            "\nlook bookcases\nlook box\nlook cabinet" +
            "\nBe aware, not all rooms or places to explore will have parts of the flashlight, however, even if they don't have " +
            "hidden pieces, they may provide helpful information, like where to look (or where not to look). " +
            "\nIf you want to check your time, use the command 'look watch' while in the main lobby." +
            "\nOnce you have found all parts of the flashlight, navigate your way back to the main lobby, it's the only place with " +
            "enough ambient light for your to assemble the flashlight pieces. ";

        public static string MainLobby = "You're in the main lobby, facing north.";

        public static string EndGame =
            "You've got all the flashlight pieces! and just in time!! Grog is right around the corner, you fumble around, throw the batteries in the handle " +
            "and screw on the bulb. Just as he runs around the corner, you shine the light on him!! " +
            "\n\nHE IS VANQUISHED!";

        public static string NotValid = "That's not a valid command.";

        public static string Lightbulb = @"
                                                 _____  
                                               .'     `.
                                              /         \
                                             |           | 
                                             '.  +^^^+  .'
                                               `. \./ .'
                                                 |_|_|  
                                                 (___)    
                                                 (___)
                                                 `---'
            ";

        public static string Handle = @"
                                               ___________
                                              /__________/|
                                              | ________ ||
                                              | ________ ||
                                              | ________ ||
                                              | ________ ||
                                              | ________ ||
                                              | ________ ||
                                              | ________ ||
                                              |__________|/
            ";

        public static string Batteries = @"
                                                 ______
                                              __|//////|__
                                              |          |
                                              |          |
                                              |   /_     |                                              
                                              |    /_    |
                                              |     /    |
                                              |          |
                                              |__________|
                                                    
            ";
    }
}
