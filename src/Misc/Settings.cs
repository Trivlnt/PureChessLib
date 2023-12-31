﻿using System;

namespace PureChessLib.src.Misc
{
    public class Settings
    {
        public bool debugMode = false;
        public bool charMode = false;
        public bool graphicalBoard = true;

        public void DebugMessage(string message)
        {
            if (!debugMode)
            {
                return;
            }

            if (message.StartsWith("§a"))
            {
                message = message.Substring(2);
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (message.StartsWith("§b"))
            {
                message = message.Substring(2);
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (message.StartsWith("§c"))
            {
                message = message.Substring(2);
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (message.StartsWith("§1"))
            {
                message = message.Substring(2);
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (message.StartsWith("§2"))
            {
                message = message.Substring(2);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else
            {
                Console.ResetColor();
            }


            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
