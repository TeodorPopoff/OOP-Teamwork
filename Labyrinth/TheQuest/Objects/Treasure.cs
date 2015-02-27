namespace TheQuest
{
    class Treasure : GameObject
    {
        public Treasure(string name, Location position)
            :base(name, position)
        {
            this.HiddenSymbol = "T";
            base.symbol = "T";
        }
    }
}
