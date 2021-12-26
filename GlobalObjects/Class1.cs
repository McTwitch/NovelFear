using System;
using System.Collections.Generic;
//using GameCharacters;
using gameObjects;

namespace GlobalObjects
{
    public class GlobalObject
    {

        public static ObservableItem Couch = new("Couch", "Worn, faded, leather", "You don't feel like sitting right now.");

        public static InteractableItem DeskBell = new("Bell", "A tarnished brass bell.", "You tap the top of the bell.");

        public static PlayerCharacter Player = new();

        public static Room Lobby = new("Lobby", 8, 8);

        
    }
}
