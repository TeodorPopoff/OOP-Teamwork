using System;
namespace TheQuest
{
    /// <summary>
    /// A base class for all living things that will participate in the game.
    /// All of the races will inherit from it.
    /// </summary>
    public abstract class Character : MovingObject
    {
        private bool isAlive;

        protected Character(string name, Location position)
            : base(name, position)
        {
            this.IsAlive = true;
        }

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }
    }
}