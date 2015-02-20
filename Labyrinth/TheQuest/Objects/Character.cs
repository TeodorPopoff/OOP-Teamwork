using System;
namespace TheQuest
{
    /// <summary>
    /// A base class for all living things that will participate in the game.
    /// All of the races will inherit from it.
    /// </summary>
    public abstract class Character : GameObject, IMove
    {
        private int healthPoints;

        protected Character(char symbol, string name, Location position, int healthPoints)
            : base(symbol, name, position)
        {
            this.HealthPoints = healthPoints;
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            set
            {
                this.healthPoints = value;
                if (this.healthPoints <= 0)
                {
                    this.IsAlive = false;
                }
            }
        }

        public virtual void Move(Direction direction, int step = 1)
        {
            int newRow = this.Position.Y;
            int newCol = this.Position.X;

            switch (direction)
            {
                case Direction.Up:
                    if (newRow - step >= 0)
                    {
                        newRow -= step;
                    }
                    break;

                case Direction.Right:
                    if (newCol + step < ConsoleSettings.ConsoleWidth)
                    {
                        newCol += step;
                    }
                    break;

                case Direction.Down:
                    if (newRow + step < ConsoleSettings.ConsoleHeight)
                    {
                        newRow += step;
                    }
                    break;

                case Direction.Left:
                    if (newCol - step >= 0)
                    {
                        newCol -= step;
                    }
                    break;

                default:
                    throw new InvalidOperationException("Invalid direction provided.");
            }
            this.Position = new Location(newCol, newRow);
        }
    }
}