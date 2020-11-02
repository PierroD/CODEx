using System;
using CODEXOffsets.Interface;
using CODEXOffsets.Utils;

namespace CODEXOffsets
{
    public class COD
    {                           // mw2   ,  mw3   , bo2   , 
        static string[] games = { "iw4mp", "iw5mp", "t6mp" };  
        static Type CallofDuty;
        static string gameName;
        public static bool checkGame()
        {

            foreach (string game in games)
            {
                if (new Trainer().Process_Handle(game))
                {
                    CallofDuty = Type.GetType("CODEXOffsets.Offsets" + "." + game);
                    gameName = game;
                    return true;
                }
            }
            return false;
        }

        public static object Game()
        {
            return Activator.CreateInstance(CallofDuty) as IOffsets;
        }

        public static string GameName()
        {
            return gameName;
        }

        public static string LongGameName()
        {
            switch (COD.GameName())
            {
                case "iw4mp":
                    return "Call of Duty Modern Warfare 2 - Multiplayer";
                case "iw5mp":
                    return "Call of Duty Modern Warfare 3 - Multiplayer";
                case "t6mp":
                    return "Call of Duty BlackOps 2 - Multiplayer";
                default:
                    return "No game detected";
            }
        }
    }
}

