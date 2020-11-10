using System;
using CODEXOffsets.Interface;
using CODEXOffsets.Utils;

namespace CODEXOffsets
{
    public class COD
    {                           // cod4mw, mw2   ,  mw3   , bo2mp, bo2zm, 
        static string[] games = {"iw3mp", "iw4mp", "iw5mp", "t6mp", "t6zm" };  
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
                case "iw3mp":
                    return "Call of Duty 4 Modern Warfare - Multiplayer";
                case "iw4mp":
                    return "Call of Duty Modern Warfare 2 - Multiplayer";
                case "iw5mp":
                    return "Call of Duty Modern Warfare 3 - Multiplayer";
                case "t6mp":
                    return "Call of Duty BlackOps 2 - Multiplayer";
                case "t6zm":
                    return "Call of Duty BlackOps 2 - Zombies";
                default:
                    return "No game detected";
            }
        }
    }
}

