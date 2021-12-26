using System;
using GameScenes;
using GlobalVariables;

namespace NovelFear
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Novel Fear";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            GlobalVariable.AvailableCmds.Add("list");
            GlobalVariable.AvailableCmds.Add("help");
            GlobalVariable.AvailableCmds.Add("inventory");
            GlobalVariable.AvailableCmds.Add("save");
            GlobalVariable.AvailableCmds.Add("exit");

            StartScreen.StartMenu();
        }
    }
}
