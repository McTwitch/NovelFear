using System;
using System.Collections.Generic;

/* 12-26-2021 - Created PlayerCharacter class in this namespace, taking it away from it's own namespace/class.
 * Changed dependency on GlobalVariables so that it wouldn't create a circular dependency. Made Character class 
 * control its own inventory.
 * */

namespace gameObjects
{
    public class GameItems
    {
        public string displayName;
        public string objDescription;
        

    }

    public class ObservableItem :GameItems
    {
        public string UseMessage;

        public ObservableItem(string string1, string string2, string string3)
        {
            displayName = string1;
            objDescription = string2;
            UseMessage = string3;

        }

        public string UseItem()
        {
            return UseMessage;
        }
    }

    public class InteractableItem :GameItems
    {
        public string UseMessage;
        public InteractableItem(string string1, string string2, string string3)
        {
            displayName = string1;
            objDescription = string2;
            UseMessage = string3;
        }

    }

    public class InventoryItem :GameItems
    {


        public InventoryItem(string string1, string string2)
        {
            displayName = string1;
            objDescription = string2;
        }

        public void UseObject(object Target)
        {

        }
    }

    public class Doors :GameItems
    {
        public bool Locked;
        public Doors(string string1, string string2, bool IsLocked)
        {
            displayName = string1;
            objDescription = string2;
            Locked = IsLocked;
        }

        public void Use()
        {
            if(Locked == true)
            {

            }

            else if (Locked != true)
            {

            }
        }
    }

    public class Room
    {
        public string RoomName;
        public List<GameItems> RoomInventory = new();
        public bool Explored;
        public bool Completed;
        public string RoomDescription;
        public Object[,] RoomMap;

        public Room(string string1, int x, int y)
        {
            RoomName = string1;
            Explored = false;
            Completed = false;
            Object[,] RoomMap = new Object[x, y];
        }

    }

    public class PlayerCharacter
    {

        public static List<InventoryItem> PlayerInventory = new List<InventoryItem>();
        public void PickUpItem(InventoryItem Target)
        {
            PlayerInventory.Add(Target);
        }

        public void Observe(GameItems Target)
        {

        }

        public void UseItem(InteractableItem Target)
        {
            Console.WriteLine(Target.UseMessage);
        }
    }



}
