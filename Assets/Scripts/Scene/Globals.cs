using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public static class Globals
    {
        public enum GamePrefs { GameMode }
        
        public enum GameMode
        {
            SinglePlayer, MultiPlayer
        }

        public enum Tags 
        {
            Player, Car, Booster
        }
    }
}
