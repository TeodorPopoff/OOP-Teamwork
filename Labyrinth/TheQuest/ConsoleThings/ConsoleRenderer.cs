using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TheQuest
{
    public class ConsoleRenderer
    {
        private char[,] world;
        private int rows;
        private int cols;

        public ConsoleRenderer(int rows, int cols)
        {
            this.world = new char[rows, cols];
            this.ClearQueue();
            this.Rows = rows;
            this.Cols = cols;
        }

        public int Cols
        {
            get { return cols; }
            set { cols = value; }
        }

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public void EnqueueForRendering(GameObject obj)
        {
            char symbol = obj.Symbol;
            int row = obj.Position.Y;
            int col = obj.Position.X;

            this.world[row, col] = symbol;
        }

        public void EnqueueForRendering(ICollection<GameObject> objects)
        {
            foreach (var obj in objects)
            {
                char symbol = obj.Symbol;
                int row = obj.Position.Y;
                int col = obj.Position.X;

                this.world[row, col] = symbol;
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
