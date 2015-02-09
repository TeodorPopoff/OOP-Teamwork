namespace Labyrinth.Objects
{
    using Labyrinth.ConsoleThings;
    using Labyrinth.Enumerations;
    using Labyrinth.Interfaces;
    using System;

    class Hero : AttackableCreature, Imovable
    {
        private const int DefaultTeam = 1;
        private MatrixCoords oldCoords;

        public Hero(MatrixCoords coords, char[,] body, double healthPoints, double defensePoints, double attackPoints, int team = Hero.DefaultTeam)
            :base(coords, body, healthPoints, defensePoints, attackPoints, team)
        {

        }

        public override void Update()
        {
            
        }

        public virtual void Move(Direction direction, int step = 1)
        {
            int newRow = this.Coords.Row;
            int newCol = this.Coords.Col;
            this.oldCoords = new MatrixCoords(this.Coords.Row, this.Coords.Col);

            switch (direction)
            {
                case Direction.Top:
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

            this.Coords.Row = newRow;
            this.Coords.Col = newCol;
        }

        public void MoveBack()
        {
            this.Coords = this.oldCoords;
        }
    }
}
