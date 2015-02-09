namespace Labyrinth.Engines
{
    using Labyrinth.Objects;
    class BattleHandler
    {
        private AttackableCreature attacker;
        private Creature defender;

        public BattleHandler(AttackableCreature attacker, Creature defender)
        {
            this.Attacker = attacker;
            this.Defender = defender;
        }

        public Creature Defender
        {
            get 
            {
                return this.defender; 
            }
            set 
            {
                this.defender = value; 
            }
        }

        public AttackableCreature Attacker
        {
            get 
            {
                return this.attacker; 
            }
            set 
            {
                this.attacker = value; 
            }
        }

        public static bool operator true(BattleHandler asd)
        {
            if (asd.attacker != null && asd.defender != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator false(BattleHandler asd)
        {
            if (asd.attacker == null && asd.defender == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
