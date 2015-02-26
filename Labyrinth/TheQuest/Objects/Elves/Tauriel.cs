using System;

namespace TheQuest
{
    public sealed class Tauriel : Elf
    {
        private bool _isAlive = true;
        private static Location _position;
        private static Tauriel hero;

        public static Tauriel GetInstance(Location position)
        {
            if (Tauriel.hero == null)
            {
                Tauriel.hero = new Tauriel(position);
                return Tauriel.hero;
            }
            else
            {
                return Tauriel.hero;
            }
        }

        private Tauriel(Location position)
            : base("Tauriel", position)
        {
            Random rnd = new Random();
            base.symbol = "E";
            base.description = "She is a captain of the Elven guard of Thranduil's woodland realm.";
            base.BattleStrength = 150;
        }
    }
}