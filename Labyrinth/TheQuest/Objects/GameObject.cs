using System;

namespace TheQuest
{
    /// <summary>
    /// This is base class for all beings and things that will participate in the game
    /// and will be located on the battlefield
    /// </summary>
    public abstract class GameObject
    {
        private string name;
        private string description;
        private char symbol;
        private bool isAlive;

        private Location position;

        protected GameObject(char symbol, string name, Location position)
        {
            this.Name = name;
            this.Position = position;
            this.Symbol = symbol;
            this.IsAlive = true;
        }

        /// <summary>
        /// What name will be displayed on screen
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        /// <summary>
        /// A short message we can write on the console, e.g. "A powerful and evil magician"
        /// </summary>
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Description cannot be null or empty.");
                }
                this.description = value;
            }
        }

        /// <summary>
        /// The location of the character on the battlefield
        /// </summary>
        public Location Position
        {
            get
            {
                return this.position;
            }

            set
            {
                if (value.X < 0 || value.Y < 0 ||
                    value.X >= ConsoleSettings.ConsoleWidth || value.Y >= ConsoleSettings.ConsoleHeight)
                {
                    return;
                }
                this.position.X = value.X;
                this.position.Y = value.Y;
            }
        }

        public char Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value; }
        }

    }
}