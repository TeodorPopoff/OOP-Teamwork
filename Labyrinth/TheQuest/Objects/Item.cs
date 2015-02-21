using System;

namespace TheQuest
{
    public abstract class Item : GameObject
    {
        protected Item(string name, Location position)
            : base(name, position)
        {
            
        }
    }
}