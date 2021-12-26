using System;
using System.Collections.Generic;
using gameObjects;
using GlobalVariables;

namespace GameCharacters
{
    public class PlayerCharacter
    {
        public string playerLocation;

        public PlayerCharacter(string string1, int xloc, int yloc)
        {
            playerLocation = string1;
            GlobalVariable.PlayerX = xloc;
            GlobalVariable.PlayerY = yloc;

        }

        public void PickUpItem(InventoryItem Target)
        {
            GlobalVariable.PlayerInventory.Add(Target);
        }

        public void Observe(gameObjects.GameItems Target)
        {

        }

        public void UseItem(gameObjects.InteractableItem Target)
        {
            Console.WriteLine(Target.UseMessage);

        }
    }

    public class NPC
    {
        public string NPCName;

        public NPC(string string1)
        {
            NPCName = string1;
        }

    }
}
