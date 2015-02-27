using System;
using System.Collections.Generic;
using System.Text;

namespace TheQuest
{
    public class ConsoleRenderer
    {
        private string[,] world;
        private int rows;
        private int cols;

        public ConsoleRenderer(int rows, int cols)
        {
            this.world = new string[rows, cols];
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
            string symbol = obj.Symbol;
            if (obj is ThorinTeam || obj is Dwarf)
            {
                symbol = obj.Symbol;
            }
            else if (obj is Enemy || obj is Friend || obj is Item)
            {
                symbol = obj.Symbol;
            }
            else
            {
                symbol = obj.Symbol;
            }

            int row = obj.Position.Y;
            int col = obj.Position.X;

            this.world[row, col] = symbol;
        }

        public void EnqueueForRendering(ICollection<GameObject> objects)
        {
            foreach (var obj in objects)
            {
                string symbol = obj.Symbol;
                if (obj is ThorinTeam)
                {
                    symbol = obj.Symbol;
                }
                else if (obj is Enemy || (obj is Friend && !(obj is Dwarf)) || obj is Item)
                {
                    symbol = obj.HiddenSymbol;
                }
                else
                {
                    symbol = obj.Symbol;
                }

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
                    string symbol = this.world[row, col];
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
                    this.world[row, col] = " ";
                }
            }
        }
    }
}
