namespace TheQuest
{
    public abstract class Elf : Friend
    {
        private int battleStrength = 110;

        protected Elf(string name, Location position)
            : base(name, position)
        {
            base.BattleStrength = battleStrength;
            base.symbol = "E";
            base.description = "The Elves are the first and oldest of the Children of Ilúvatar and are considered to be the fairest and wisest race.";
        }
    }
}