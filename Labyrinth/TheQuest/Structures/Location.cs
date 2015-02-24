namespace TheQuest
{
    /// <summary>
    /// Structure that will hold the location of each GameObject on the battlefield
    /// </summary>
    public struct Location
    {
        private int x;
        private int y;

        public Location(int x,  int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }
        /// <summary>
        /// The X coordinate on the Battlefield (rows)
        /// </summary>
        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                this.x = value;
            }
        }

        /// <summary>
        /// The Y coordinate on the Battlefield (columns)
        /// </summary>
        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }

        public static bool operator ==(Location a, Location b)
        {
            if (a.X == b.X && a.Y == b.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Location a, Location b)
        {
            if (a.X == b.X && a.Y == b.Y)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}