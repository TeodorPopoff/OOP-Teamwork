using System;

namespace TheQuest
{
    /// <summary>
    /// This is base class for all beings and things that will participate in the game
    /// and will be located on the battlefield
    /// </summary>
    public abstract class GameObject 
        //Remove IMove from here and put it into Character
    {
        private const int battlefieldSize = 100;
        private string name;
        private string description;
        private Location position;
        private char symbol;

        public char Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }


        protected GameObject(char symbol, string name, string description, Location position)
        {
            this.Name = name;
            this.Description = description;
            this.Position = position;
            this.Symbol = symbol;
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
        /// The Unicode symbol used to draw the character on the console
        /// </summary>

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
                    value.X >= battlefieldSize || value.Y >= battlefieldSize)
                {
                    return;
                }
                this.position.X = value.X;
                this.position.Y = value.Y;
            }
        }
    }
}