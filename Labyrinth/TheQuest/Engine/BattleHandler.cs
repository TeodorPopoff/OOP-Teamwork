using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class BattleHandler
    {
        private Friend attacker;
        private Enemy defender;

        public BattleHandler(Friend attacker, Enemy defender)
        {
            this.Attacker = attacker;
            this.Defender = defender;
        }

        public Enemy Defender
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

        public Friend Attacker
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
