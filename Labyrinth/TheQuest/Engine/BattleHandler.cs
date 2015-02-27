namespace TheQuest
{
    class BattleHandler
    {
        private Friend friend;
        private Enemy enemy;

        public BattleHandler(Friend friend, Enemy enemy)
        {
            this.Friend = friend;
            this.Enemy = enemy;
        }

        public Enemy Enemy
        {
            get
            {
                return this.enemy;
            }
            set
            {
                this.enemy = value;
            }
        }

        public Friend Friend
        {
            get
            {
                return this.friend;
            }
            set
            {
                this.friend = value;
            }
        }

        public static bool operator true(BattleHandler asd)
        {
            if (asd.friend != null && asd.enemy != null)
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
            if (asd.friend == null && asd.enemy == null)
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
