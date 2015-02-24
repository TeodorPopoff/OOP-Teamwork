namespace TheQuest
{
    public class Wall : GameObject
    {
        public Wall(string symbol, Location position, string name = "null")
            :base(name, position)
        {
            this.symbol = symbol;
        }
    }
}
