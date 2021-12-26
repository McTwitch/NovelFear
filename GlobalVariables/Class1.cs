using System;
using System.Collections.Generic;
//using gameObjects;

/* Removed gameObjects reference to create Player Character in GO namespace.
 * Removed List<InventoryItem> PlayerInventory and moved to new Player class. Create
 * Player object in GlobalObjects to make inventory accessible?
 * */

namespace GlobalVariables
{

    public class GlobalVariable
    {
        public static string CharacterName;
        //public static List<InventoryItem> PlayerInventory = new();
        public static string CurrentLocation;
        public static string PlayerCommand;
        public static List<string> AvailableCmds = new();
        public static int PlayerX;
        public static int PlayerY;

        // Added the below in an attempt to move control from GameScenes to ConsoleParser.
        public static string CurrentScene = "StartScreen";
        public static string NextScene;
        
    }
}
