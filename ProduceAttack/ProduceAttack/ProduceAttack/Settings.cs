using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProduceAttack
{
    public static class Settings
    {
        public static bool isDebug = false; 

        public enum GameState
        {
            ControllerDetect,
        }

        public static GameState gameState = GameState.ControllerDetect; //default to intro on game startup

    }
}
