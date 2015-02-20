using System;

namespace TheQuest
{
    public abstract class Item : GameObject
    {
        protected Item(char symbol, string name, Location position)
            : base(symbol, name, position)
        {
            //random number for position on the screen for the item
            Random randomNumber = new Random();

            //set a random position on the screen
            //Location randomItem = new Location(randomNumber.Next(0, ConsoleSettings.ConsoleHeight), randomNumber.Next(0, ConsoleSettings.ConsoleWidth));
        }
    }
}