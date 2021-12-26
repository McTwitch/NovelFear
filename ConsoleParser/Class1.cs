using System;
using System.Collections.Generic;
using System.Linq;
using GlobalVariables;
using GlobalObjects;


namespace ConsoleParser
{

    public  class GameParser
    {
        public static object CurrentRoom;
        public static int ListLength = 0;
        public static string UserInput = "";
        public static string Direction = "";
        public static void Parse(string string1)
        {
            switch (string1)
            {
                case "list":
                    ListLength = GlobalVariable.AvailableCmds.Count;
                    foreach (string CMD in GlobalVariable.AvailableCmds)
                    {
                        Console.WriteLine(CMD);
                    }

                    break;

                case "help":
                    break;

                case "move":
                    Console.WriteLine("Move where?");
                    Console.Write(">>> ");
                    Direction = Console.ReadLine();

                    switch (Direction)
                    {
                        case "north":
                            GlobalVariable.PlayerY = GlobalVariable.PlayerY ++;
                            Console.WriteLine($"{GlobalVariable.PlayerX} + {GlobalVariable.PlayerY}" );
                            Console.ReadKey();
                            break;

                        case "south":
                            GlobalVariable.PlayerY = GlobalVariable.PlayerY --;
                            Console.WriteLine($"{GlobalVariable.PlayerX} + {GlobalVariable.PlayerY}");
                            Console.ReadKey();
                            break;

                        case "east":
                            GlobalVariable.PlayerX = GlobalVariable.PlayerX ++;
                            Console.WriteLine($"{GlobalVariable.PlayerX} + {GlobalVariable.PlayerY}");
                            Console.ReadKey();
                            break;

                        case "west":
                            GlobalVariable.PlayerX = GlobalVariable.PlayerX --;
                            Console.WriteLine($"{GlobalVariable.PlayerX} + {GlobalVariable.PlayerY}");
                            Console.ReadKey();
                            break;
                    }
                    
                    break;

                case "use":
                    Console.WriteLine("Use what?");
                    Console.Write(">>> ");
                    switch(Console.ReadLine())
                    {
                        case "bell":
                            GlobalObject.Player.UseItem(GlobalObject.DeskBell);
                            break;
                            
                    }


                    break;

            }

            Console.ReadKey();
            InputPrompt();
            
        }

        public static void InputPrompt()
        {
            Console.WriteLine("What do you do?");
            Console.Write(">>> ");
            UserInput = Console.ReadLine();
            Parse(UserInput.ToLower());
            
        }
    }
}
