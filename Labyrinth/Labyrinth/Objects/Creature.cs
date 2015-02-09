namespace Labyrinth.Objects
{
    abstract class Creature : GameObject
    {
        private string name;
        private double healthPoints;
        private double defensePoints;

        public Creature(MatrixCoords coords, char[,] body, double healthPoints, double defensePoints, int team)
            :base(coords, body, team)
        {
            this.HealthPoints = healthPoints;
            this.DefensePoints = defensePoints;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                this.name = value;
            }
        }

        public double DefensePoints
        {
            get
            {
                return this.defensePoints;
            }
            protected set
            {
                this.defensePoints = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public override void Update()
        {
            
        }

        public override string ToString()
        {
            return string.Format("{0} - HP:{1}, Defense:{2}", this.GetType().Name, this.HealthPoints, this.DefensePoints);
        }
    }
}
