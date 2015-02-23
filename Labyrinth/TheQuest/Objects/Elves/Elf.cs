﻿namespace TheQuest
{
    public abstract class Elf : Friend
    {
        private int battleStrength = 110;

        public Elf(string name, Location position)
            : base(name, position)
        {
            BattleStrength = battleStrength;
            symbol = "u+26E8";
            description = "A skilled archer, and magician very wise in battle";
        }

        public override string Description
        {
            get { return base.description; }
        }

        public override string Symbol
        {
            get { return base.symbol; }
        }
    }
}