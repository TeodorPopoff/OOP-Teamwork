using System;

namespace TheQuest
{
    public sealed class Thranduil : Elf
    {
        private bool _isAlive = true;
        private static Location _position;
        private static Thranduil hero;

        public static Thranduil GetInstance(Location position)
        {
            if (Thranduil.hero == null)
            {
                Thranduil.hero = new Thranduil(position);
                return Thranduil.hero;
            }
            else
            {
                return Thranduil.hero;
            }
        }

        private Thranduil(Location position)
            : base("Thranduil", position)
        {
            Random rnd = new Random();
            base.symbol = "Th";
            base.description = "The elven King of Mirkwood.";
            base.BattleStrength = 200;
        }
    }
}