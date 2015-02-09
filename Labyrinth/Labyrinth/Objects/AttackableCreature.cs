namespace Labyrinth.Objects
{
    using Labyrinth.Interfaces;

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
            creature.HealthPoints -= this.AttackPoints;
        }
    }
}
