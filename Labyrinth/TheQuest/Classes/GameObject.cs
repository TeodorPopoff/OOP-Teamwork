using System;

namespace TheQuest
{
    /// <summary>
    /// This is base class for all beings and things that will participate in the game
    /// and will be located on the battlefield
    /// </summary>
    public abstract class GameObject : IMove
    {
        private const int battlefieldSize = 100;
        private string name;
        private string description;
        private Location position;

        protected GameObject(string name, string description, Location position)
        {
            this.Name = name;
            this.Description = description;
            this.Position = position;
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
        public abstract char Symbol
        {
            get;
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
                    value.X >= battlefieldSize || value.Y >= battlefieldSize)
                {
                    return;
                }
                this.position.X = value.X;
                this.position.Y = value.Y;
            }
        }

        void IMove.MoveRight()
        {
            this.Position = new Location(this.position.X, this.Position.Y + 1);
        }

        void IMove.MoveLeft()
        {
            this.Position = new Location(this.position.X, this.Position.Y - 1);
        }

        void IMove.MoveUp()
        {
            this.Position = new Location(this.position.X - 1, this.Position.Y);
        }

        void IMove.MoveDown()
        {
            this.Position = new Location(this.position.X + 1, this.Position.Y);
        }
    }
}