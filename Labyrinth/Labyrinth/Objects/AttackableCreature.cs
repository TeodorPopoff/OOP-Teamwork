namespace Labyrinth.Objects
{
    using Labyrinth.Interfaces;
    using System.Threading;

    abstract class AttackableCreature : Creature, IAttack
    {
        private double attackPoints;

        public AttackableCreature(MatrixCoords coords, char[,] body, double healthPoints, double defensePoints, double attackPoints, int team)
            :base(coords, body, healthPoints, defensePoints, team)
        {
            this.AttackPoints = attackPoints;
        }

        public override void Update()
        {
            
        }

        public double AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                this.attackPoints = value;
            }
        }

        public void Attack(Creature creature)
        {
            Thread.Sleep(500);
            if (this.Coords.Col > creature.Coords.Col)
            {

            }
            creature.HealthPoints -= this.AttackPoints;
        }
    }
}
