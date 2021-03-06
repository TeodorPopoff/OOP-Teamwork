﻿using System;
namespace TheQuest
{
    public abstract class MovingObject : GameObject, IMove
    {
        private string defaultSymbol = "@";
        private Location oldPosition;

        public MovingObject(string name, Location position)
            :base(name, position)
        {

        }

        public virtual void Move(Direction direction, int step = 1)
        {
            int newRow = this.Position.Y;
            int newCol = this.Position.X;
            this.oldPosition = new Location(this.Position.X, this.Position.Y);

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

        public void MoveBack()
        {
            this.Position = new Location(this.oldPosition.X, this.oldPosition.Y);
        }
    }
}
