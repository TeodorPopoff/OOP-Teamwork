using System;

namespace TheQuest
{
    public sealed class Legolas : Elf
    {
        private bool _isAlive = true;
        private static Location _position;
        private static Legolas hero;

        public static Legolas GetInstance(Location position)
        {
            if (Legolas.hero == null)
            {
                Legolas.hero = new Legolas(position);
                return Legolas.hero;
            }
            else
            {
                return Legolas.hero;
            }
        }

        private Legolas(Location position)
            : base("Legolas", position)
        {
            Random rnd = new Random();
            base.symbol = "L";
            base.description = "He is the son of the Elf-king Thranduil of Mirkwood, a Prince of the Woodland Realm (Mirkwood), a messenger, and a master bowman.";
            base.BattleStrength = 170;
        }
    }
}