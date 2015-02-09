namespace Labyrinth.ConsoleThings
{
    using System;
    using Labyrinth.Interfaces;
    using System.Text;

    class ConsoleRenderer : IRenderer
    {
        private char[,] world;

        public ConsoleRenderer(int rows, int cols)
        {
            this.world = new char[rows, cols];
            this.ClearQueue();
        }

        public void EnqueueForRendering(GameObject obj)
        {
            char[,] image = obj.GetImage();

            MatrixCoords topLeft = obj.Coords;
            int rows = image.GetLength(0) + obj.Coords.Row;
            int cols = image.GetLength(1) + obj.Coords.Col;

            for (int row = topLeft.Row, imageRow = 0; row < rows; row++, imageRow++)
            {
                for (int col = topLeft.Col, imageCol = 0; col < cols; col++, imageCol++)
                {
                    this.world[row, col] = image[imageRow, imageCol];
                }
            }
        }

        public void RenderAll()
        {
            Console.SetCursorPosition(0, 0);
            StringBuilder output = new StringBuilder();

            for (int row = 0; row < this.world.GetLength(0); row++)
            {
                for (int col = 0; col < this.world.GetLength(1); col++)
                {
                    char symbol = this.world[row, col];
                    output.Append(this.world[row, col]);
                }
                output.Append(Environment.NewLine);
            }

            Console.Write(output);
        }

        public void ClearQueue()
        {
            for (int row = 0; row < this.world.GetLength(0); row++)
            {
                for (int col = 0; col < this.world.GetLength(1); col++)
                {
                    this.world[row, col] = ' ';
                }
            }
        }
    }
}
