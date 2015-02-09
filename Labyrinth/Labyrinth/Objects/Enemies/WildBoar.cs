namespace Labyrinth.Objects.Enemies
{
    using Labyrinth.Interfaces;

    class WildBoar : AttackableCreature
    {
        private const int DefaultTeam = 2;
        private const double DefaultHealthPoints = 100;
        private const double DefaultDefensePoints = 10;
        private const double DefaultAttackPoints = 15;

        public WildBoar(MatrixCoords coords, char[,] body,
            double healthPoints = WildBoar.DefaultHealthPoints,
            double defensePoints = WildBoar.DefaultDefensePoints,
            double attackPoints = WildBoar.DefaultAttackPoints,
            int team = WildBoar.DefaultTeam)
            : base(coords, body, healthPoints, defensePoints, attackPoints, team)
        {

        }
    }
}
