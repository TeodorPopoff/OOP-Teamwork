namespace Labyrinth.Engines
{
    using Labyrinth.ConsoleThings;
    using Labyrinth.Interfaces;
    using Labyrinth.Objects;

    class BattleEngine
    {
        private IRenderer renderer;
        private AttackableCreature attacker;
        private Creature defender;

        public BattleEngine(IRenderer renderer, AttackableCreature attacker, Creature defender)
        {
            this.renderer = renderer;
            this.attacker = attacker;
            this.defender = defender;
        }

        public void Run()
        {

        }
    }
}
