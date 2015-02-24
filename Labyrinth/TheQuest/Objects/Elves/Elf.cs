namespace TheQuest
{
    public abstract class Elf : Friend
    {
        private int battleStrength = 110;

        public Elf(string name, Location position)
            : base(name, position)
        {
            BattleStrength = battleStrength;
            base.symbol = "E";
            base.description = "A skilled archer, and magician very wise in battle";
        }
    }
}