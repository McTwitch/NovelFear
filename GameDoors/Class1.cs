using System;

namespace GameDoors
{
    public class Door
    {
        public string DoorName;
        public string DoorDescription;
        public bool Locked;

        public Door(string string1, string string2, bool bool1)
        {
            DoorName = string1;
            DoorDescription = string2;
            Locked = bool1;
        }

        public Door()
        {
            DoorName = "Generic";
            DoorDescription = "Just an everyday, normal wooden door";
            Locked = true;
        }
    }
}
