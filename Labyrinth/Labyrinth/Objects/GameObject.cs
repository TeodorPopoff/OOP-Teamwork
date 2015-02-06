namespace Labyrinth
{
    using Labyrinth.Interfaces;

    abstract class GameObject : IRenderable
    {
        private char[,] body;
        protected MatrixCoords coords;
        public bool isAlive;

        public GameObject(MatrixCoords coords, char[,] body)
        {
            this.Coords = coords;
            this.body = body;
            this.isAlive = true;
        }

        public MatrixCoords Coords
        {
            get
            {
                return this.coords;
            }
            protected set
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

        public abstract void Update();
    }
}
