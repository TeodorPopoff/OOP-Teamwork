namespace Labyrinth.Objects
{
    using Labyrinth.Enumerations;
    using Labyrinth.Interfaces;
    using System;

    class Hero : GameObject, Imovable
    {
        public Hero(MatrixCoords coords, char[,] body)
            :base(coords, body)
        {

        }

        public override void Update()
        {
            
        }

        public virtual void Move(Direction direction, int step = 1)
        {
            int newRow = this.Coords.Row;
            int newCol = this.Coords.Col;

            switch (direction)
            {
                case Direction.Top:
                    if (newRow - step >= 0)
                    {
                        newRow -= step;
                    }
                    break;

                case Direction.Right:
                    if (newCol + step < 20)
                    {
                        newCol += step;
                    }
                    break;

                case Direction.Down:
                    if (newRow + step < 20)
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

            this.Coords.Row = newRow;
            this.Coords.Col = newCol;
        }
    }
}
