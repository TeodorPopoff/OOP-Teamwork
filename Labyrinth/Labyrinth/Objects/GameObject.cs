namespace Labyrinth
{
    using Labyrinth.Interfaces;

    abstract class GameObject : IRenderable, ICollidable
    {
        private char[,] body;
        protected MatrixCoords coords;
        public bool IsAlive {get; set;}
        private int team; // Used for recognize the enemies and allies

        public GameObject(MatrixCoords coords, char[,] body, int team)
        {
            this.Coords = coords;
            this.body = body;
            this.IsAlive = true;
            this.Team = team;
        }

        public MatrixCoords Coords
        {
            get
            {
                return this.coords;
            }
            set
            {
                this.coords = value;
            }
        }

        public char[,] GetImage()
        {
            char[,] copy = new char[this.body.GetLength(0), this.body.GetLength(1)];

            for (int row = 0; row < copy.GetLength(0); row++)
            {
                for (int col = 0; col < copy.GetLength(1); col++)
                {
                    copy[row, col] = this.body[row, col];
                }
            }

            return copy;
        }

        public int Team
        {
            get
            {
                return this.team;
            }
            protected set
            {
                this.team = value;
            }
        }

        public abstract void Update();

        public void ChangeImage(char[,] newImage)
        {
            this.body = newImage;
        }

        public bool CanCollideWith(GameObject obj)
        {
            if (this.Coords.Row == obj.Coords.Row && this.Coords.Col == obj.Coords.Col)
            {
                return this.Team != obj.Team;
            }
            else
            {
                return false;
            }
        }
    }
}
