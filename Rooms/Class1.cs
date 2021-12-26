using System;
using System.Collections.Generic;
using gameObjects;

namespace Rooms
{
    public class Room
    {
        public string RoomName;
        public List<GameItems> RoomInventory = new();
        public bool Explored;
        public bool Completed;
        public string RoomDescription;
        public GameItems[,] RoomMap;

        public Room(string string1, int x, int y)
        {
            RoomName = string1;
            Explored = false;
            Completed = false;
            GameItems[,] RoomMap = new GameItems[x, y];
        }

    }

}
