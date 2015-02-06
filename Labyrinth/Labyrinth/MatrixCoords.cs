namespace Labyrinth
{
    class MatrixCoords
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public MatrixCoords(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public static MatrixCoords operator +(MatrixCoords a, MatrixCoords b)
        {
            return new MatrixCoords(a.Row + b.Row, a.Col + b.Col);
        }

        public static MatrixCoords operator -(MatrixCoords a, MatrixCoords b)
        {
            return new MatrixCoords(a.Row - b.Row, a.Col - b.Col);
        }
    }
}
