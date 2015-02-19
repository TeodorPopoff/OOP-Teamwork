using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheQuest
{
    public class KeyListener
    {
        public event System.EventHandler OnLeftPressed;

        public event System.EventHandler OnRightPressed;

        public event System.EventHandler OnUpPressed;

        public event System.EventHandler OnDownPressed;

        public void ProcessInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                while (Console.KeyAvailable) // for improved character move, not lagging and atc.
                {
                    Console.ReadKey(true);
                }

                if (key.Key == ConsoleKey.A || key.Key == ConsoleKey.LeftArrow)
                {
                    this.OnLeftPressed(this, new EventArgs());
                }
                if (key.Key == ConsoleKey.D || key.Key == ConsoleKey.RightArrow)
                {
                    this.OnRightPressed(this, new EventArgs());
                }
                if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow)
                {
                    this.OnUpPressed(this, new EventArgs());
                }
                if (key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow)
                {
                    this.OnDownPressed(this, new EventArgs());
                }
            }
        }
    }
}