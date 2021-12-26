using System;
using System.Collections.Generic;
using GlobalVariables;
using ConsoleParser;
using GlobalObjects;

namespace GameScenes
{
    public class StartScreen
    {
        
        public static void StartMenu()
        {
            Console.Clear();
            Console.WriteLine($"************************************************************\n" +
                               "*                                                          *\n" +
                               "*                   Welcome to Novel Fear!                 *\n" +
                               "*                                                          *\n" +
                               "************************************************************");
            Console.WriteLine($"*             Please type your selection below:            *\n" +
                               "*                         New Game                         *\n" +
                               "*                         Load Save                        *\n" +
                               "*                         About                            *\n" +
                               "*                         Options                          *\n" +
                               "*                         Exit                             *\n" +
                               "************************************************************");
            Console.Write(">>> ");
            GlobalVariable.PlayerCommand = Console.ReadLine();

            switch(GlobalVariable.PlayerCommand)
            {
                case "New Game":
                    NewGameScreen.NewGame();
                    break;

                case "Load Save":
                    LoadGameScreen.LoadGame();
                    break;

                case "About":
                    AboutScreen.About();
                    break;

                case "Options":
                    OptionsScreen.Options();
                    break;

                default:
                    break;
            }
        }
       
    }
    public class NewGameScreen
    {
        public static void NewGame()
        {
            Console.Clear();
            Console.WriteLine($"************************************************************\n" +
                               "*You find yourself on the tail end of a long, boring drive.*\n" +
                               "*Your route has taken you through the deserts of the       *\n" +
                               "*Pacific southwest. It has been hours since you last       *\n" +
                               "*stopped, and it's only getting later. The glowing numbers *\n" +
                               "*on the clock in your center console proclaim the time as  *\n" +
                               "*just after one in the morning. You try to stifle a yawn,  *\n" +
                               "*but you know that you're going to need to stop sooner     *\n" +
                               "*rather than later.                                        *\n" +
                               "************************************************************");

            Console.Write("Press any key to continue...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("************************************************************\n" +
                              "*You finally spot it in the distance -- the red glowing    *\n" +
                              "*sign. Even if it's just a parking lot, it would still be a*\n" +
                              "*place for you to stop, stretch your legs, maybe even get a*\n" +
                              "*nap in before continuing on.                              *\n" +
                              "************************************************************");

            Console.Write("Press any key to continue...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("************************************************************\n" +
                              "*But your luck seems to hold. As you draw closer, your     *\n" +
                              "*luck seems to be holding. The neon sign, antiquated but   *\n" +
                              "*still somehow still perfectly at home there in the endless*\n" +
                              "*expanse of desert, proudly announces that you've arrived  *\n" +
                              "*at the Sweet Oasis Inn.                                   *\n" +
                              "************************************************************");

            Console.Write("Press any key to continue...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("************************************************************\n" +
                              "*The gravel crunches under your feet as you exit the car.  *\n" +
                              "*As you have come to learn, the desert is a particular     *\n" +
                              "*quiet and lonely place, no more so than at night.         *\n" +
                              "*You hurry across the parking lot, and through the double  *\n" +
                              "*doors to the lobby, grateful for an escape from the long  *\n" +
                              "*expanse of night.                                         *\n" +
                              "************************************************************");

            Console.Write("Press any key to continue...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("************************************************************\n" +
                              "*The hum of the air conditioner and the welcome cool breeze*\n" +
                              "*greet you as you enter. The hotel seemed to be welcoming  *\n" +
                              "*you, not unlike your own home.                            *\n" +
                              "************************************************************");

            Console.Write("Press any key to continue...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("************************************************************\n" +
                              "*The lobby is sparsely decorated, but brightly lit. The    *\n" +
                              "*walls are painted a drab tan. A beaten, worn sofa sits    *\n" +
                              "*against the wall to your left, accompanied by end tables  *\n" +
                              "*to either side and a coffee table in front of it. The wall*\n" +
                              "*to your right has a couple of uncomfortable looking chairs*\n" +
                              "*on either side of a single end table.                     *\n" +
                              "*In the far right corner is what you assume to be the front*\n" +
                              "desk, behind which is a closed door. Slightly to its left  *\n" +
                              "is an opening, arguably to the rest of the hotel.          *\n" +
                              "************************************************************");

            Console.WriteLine("What do you do? (Type 'List' for a list of available        ");
            Console.WriteLine("actions.)");
            Console.Write(">>> ");
            GlobalVariable.PlayerCommand = Console.ReadLine();
            GameParser.Parse(GlobalVariable.PlayerCommand);
        }
        

        
    }

    public class Scene1
    {


        public Scene1()
        {
            GameParser.CurrentRoom = GlobalObject.Lobby;
            GlobalObject.Lobby.RoomMap[0, 4] = GlobalObject.Couch;
            GlobalObject.Lobby.RoomMap[0, 3] = GlobalObject.Couch;
            GlobalObject.Lobby.RoomMap[4, 5] = GlobalObject.DeskBell;
            GlobalObject.Lobby.RoomMap[GlobalVariable.PlayerX, GlobalVariable.PlayerY] = GlobalObject.Player;

        }

        
    }

    public class LoadGameScreen
    {

        public static void LoadGame()
        {
            Console.Clear();
            Console.WriteLine("************************************************************\n" +
                              "*                         Load Game                        *\n" +
                              "************************************************************\n" +
                              "*                    Currently Unavailable                 *\n" +
                              "************************************************************");
            Console.WriteLine("Press any key to return to the selection screen.");
            Console.ReadKey();
            StartScreen.StartMenu();


        }
    }

    public class AboutScreen
    {
        public static void About()
        {
            Console.WriteLine("************************************************************\n" +
                              "*                    Currently Unavailable                 *\n" +
                              "************************************************************");
            Console.WriteLine("Press any key to return to the selection screen.");
            Console.ReadKey();
            StartScreen.StartMenu();
        }
    }

    public class OptionsScreen
    {
        public static void Options()
        {
            Console.WriteLine("************************************************************\n" +
                              "*                    Currently Unavailable                 *\n" +
                              "************************************************************");
            Console.WriteLine("Press any key to return to the selection screen.");
            Console.ReadKey();
            StartScreen.StartMenu();
        }
    }
}
